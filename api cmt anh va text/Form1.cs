using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using RestSharp;
using Newtonsoft.Json;
using System.Threading;

namespace api_cmt_anh_va_text
{

    public partial class Form1 : Form
    {
        private List<string> _postIds;
        private readonly FacebookAPI _facebookAPI;
        private readonly FacebookGroupPostsAPI _facebookAPI2;

        public Form1()
        {
            InitializeComponent();
            _facebookAPI = new FacebookAPI();
            _facebookAPI2 = new FacebookGroupPostsAPI();
        }


        private async void btnPostCmt_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox2 và TextBox3
            string message = textBox2.Text;
            string imagePath = textBoxImagePath.Text;

            // Kiểm tra xem danh sách bài viết có tồn tại không
            if (_postIds == null || _postIds.Count == 0)
            {
                MessageBox.Show("Không có bài viết nào để comment.");
                return;
            }

            // Lấy danh sách token từ txtToken (dạng multi-line)
            string[] tokens = txtToken.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Lấy token đầu tiên từ danh sách tokens
            string accessToken = tokens.FirstOrDefault()?.Trim();

            // Kiểm tra xem có token nào tồn tại không
            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("Không có token nào để sử dụng.");
                return;
            }

            // Khởi tạo yêu cầu REST
            var client = new RestClient("https://graph.facebook.com/v19.0");

            // Lặp qua danh sách các bài viết và gửi comment cho mỗi bài viết
            foreach (string postId in _postIds)
            {
                var request = new RestRequest($"/{postId}/comments", Method.Post);
                request.AddParameter("message", message);

                if (!string.IsNullOrEmpty(imagePath))
                {
                    request.AddFile("attachment", imagePath);
                }


                request.AddParameter("access_token", accessToken);

                var response = await client.ExecuteAsync(request);

                // Lấy nội dung của phản hồi
                string content = response.Content;

                // Sử dụng phương thức Invoke để truy cập control txtKetQuaCmt từ luồng chính
                txtKetQuaCmt.Invoke((MethodInvoker)delegate {
                    // Gán nội dung vào TextBox txtKetQuaCmt
                    txtKetQuaCmt.Text = content;
                });

                // Nghỉ một khoảng thời gian trước khi gửi request tiếp theo (nếu cần)
                await Task.Delay(1000); // Đợi 1 giây trước khi gửi request tiếp theo (có thể điều chỉnh thời gian nghỉ tùy ý)
            }
        }




        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            openFileDialog.Title = "Chọn ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxImagePath.Text = openFileDialog.FileName;
            }
        }

        private void btnGetGroups_Click(object sender, EventArgs e)
        {
            // Gọi phương thức GetJoinedGroups từ FacebookAPI để lấy danh sách nhóm
            string accessToken = txtToken.Text;
            string jsonResponse = _facebookAPI.GetJoinedGroups(accessToken);

            // Phân tích dữ liệu JSON thành danh sách nhóm
            var groupData = JsonConvert.DeserializeObject<GroupData>(jsonResponse);

            foreach (var group in groupData.data)
            {
                int rowIndex = dataGridViewGroups.Rows.Add();
                dataGridViewGroups.Rows[rowIndex].Cells[0].Value = false; // Chọn mặc định là false
                dataGridViewGroups.Rows[rowIndex].Cells[1].Value = group.name;
                dataGridViewGroups.Rows[rowIndex].Cells[2].Value = group.id;
            }
            labelGroupCount.Text = " " + groupData.data.Count;
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                bool isChecked = checkBox.Checked;
                foreach (DataGridViewRow row in dataGridViewGroups.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["Column1"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = isChecked;
                    }
                }
                GetAllGroupPosts();
            }
        }

        private void btnGetPosts_Click(object sender, EventArgs e)
        {
            // Lấy token từ TextBox1
            string accessToken = txtToken.Text;

            // Kiểm tra xem token có được cung cấp không
            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("Vui lòng nhập token.");
                return;
            }

            // Gọi phương thức để lấy tất cả bài viết từ tất cả các nhóm
            GetSelectedGroupPosts();

        }


        private void GetSelectedGroupPosts()
        {
            int totalPosts = 0; // Khởi tạo biến để lưu tổng số bài viết
            List<string> allPostIds = new List<string>(); // Tạo danh sách mới để lưu trữ tất cả các ID bài viết

            // Lặp qua từng hàng trong DataGridView
            foreach (DataGridViewRow row in dataGridViewGroups.Rows)
            {
                // Kiểm tra xem checkbox ở hàng đó có được tích hay không
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Column1"] as DataGridViewCheckBoxCell;
                bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                if (isChecked)
                {
                    // Lấy ID nhóm từ cột dtgvIDNhom
                    string groupId = row.Cells["dtgvIDNhom"].Value?.ToString();

                    // Kiểm tra xem ID nhóm có tồn tại không
                    if (!string.IsNullOrEmpty(groupId))
                    {
                        // Lấy danh sách ID bài viết từ nhóm
                        List<string> postIds = _facebookAPI2.GetGroupPostIds(groupId, txtToken.Text);
                        allPostIds.AddRange(postIds); // Thêm các ID bài viết từ nhóm hiện tại vào danh sách tổng

                        // Cộng số bài viết của nhóm hiện tại vào tổng số bài viết
                        totalPosts += postIds.Count;

                        // Xử lý danh sách ID bài viết (ví dụ: hiển thị hoặc lưu trữ)
                        foreach (string postId in postIds)
                        {
                            Console.WriteLine($"{postId}");
                        }
                    }
                }
            }

            // Gán danh sách tổng các ID bài viết cho biến _postIds
            _postIds = allPostIds;

            // Hiển thị tổng số bài viết lên lblPostCount
            lblPostCount.Text = totalPosts.ToString();
        }
        private void GetAllGroupPosts()
        {
            int totalPosts = 0; // Khởi tạo biến để lưu tổng số bài viết

            // Tạo một danh sách để lưu trữ tất cả các ID bài viết từ tất cả các nhóm
            List<string> allPostIds = new List<string>();

            // Lặp qua từng hàng trong DataGridView
            foreach (DataGridViewRow row in dataGridViewGroups.Rows)
            {
                // Kiểm tra xem checkbox ở hàng đó có được tích hay không
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Column1"] as DataGridViewCheckBoxCell;
                bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                if (isChecked)
                {
                    // Lấy ID nhóm từ cột dtgvIDNhom
                    string groupId = row.Cells["dtgvIDNhom"].Value?.ToString();

                    // Kiểm tra xem ID nhóm có tồn tại không
                    if (!string.IsNullOrEmpty(groupId))
                    {
                        // Lấy danh sách ID bài viết từ nhóm
                        List<string> postIds = _facebookAPI2.GetGroupPostIds(groupId, txtToken.Text);

                        // Thêm các ID bài viết từ nhóm hiện tại vào danh sách tổng
                        allPostIds.AddRange(postIds);

                        // Cộng số bài viết của nhóm hiện tại vào tổng số bài viết
                        totalPosts += postIds.Count;

                        // Xử lý danh sách ID bài viết (ví dụ: hiển thị hoặc lưu trữ)
                        foreach (string postId in postIds)
                        {
                            Console.WriteLine($"{postId}");
                        }
                    }
                }
            }

            // Gán danh sách tổng các ID bài viết cho biến _postIds
            _postIds = allPostIds;

            // Hiển thị tổng số bài viết lên lblPostCount
            lblPostCount.Text = totalPosts.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit    ();
        }
    }

}
