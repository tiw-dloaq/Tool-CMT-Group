namespace api_cmt_anh_va_text
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPostCmt = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnGetGroups = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtgvNameGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvIDNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPostCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGroupCount = new System.Windows.Forms.Label();
            this.btnGetPosts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKetQuaCmt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBoxSelectAll);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.textBoxImagePath);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnPostCmt);
            this.panel1.Location = new System.Drawing.Point(523, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 455);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Message :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đường Dẫn Ảnh";
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(5, 433);
            this.checkBoxSelectAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(142, 20);
            this.checkBoxSelectAll.TabIndex = 5;
            this.checkBoxSelectAll.Text = "Chọn Tất Cả Nhóm";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(353, 364);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(125, 39);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Chọn Ảnh";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Location = new System.Drawing.Point(108, 375);
            this.textBoxImagePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(239, 22);
            this.textBoxImagePath.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 342);
            this.textBox2.TabIndex = 2;
            // 
            // btnPostCmt
            // 
            this.btnPostCmt.Location = new System.Drawing.Point(353, 414);
            this.btnPostCmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostCmt.Name = "btnPostCmt";
            this.btnPostCmt.Size = new System.Drawing.Size(125, 39);
            this.btnPostCmt.TabIndex = 4;
            this.btnPostCmt.Text = "Đăng Bình Luận";
            this.btnPostCmt.UseVisualStyleBackColor = true;
            this.btnPostCmt.Click += new System.EventHandler(this.btnPostCmt_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(61, 12);
            this.txtToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(441, 104);
            this.txtToken.TabIndex = 7;
            // 
            // btnGetGroups
            // 
            this.btnGetGroups.Location = new System.Drawing.Point(331, 356);
            this.btnGetGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetGroups.Name = "btnGetGroups";
            this.btnGetGroups.Size = new System.Drawing.Size(171, 33);
            this.btnGetGroups.TabIndex = 1;
            this.btnGetGroups.Text = "Lấy Danh Sách Nhóm";
            this.btnGetGroups.UseVisualStyleBackColor = true;
            this.btnGetGroups.Click += new System.EventHandler(this.btnGetGroups_Click);
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dtgvNameGroup,
            this.dtgvIDNhom});
            this.dataGridViewGroups.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.RowHeadersWidth = 51;
            this.dataGridViewGroups.RowTemplate.Height = 24;
            this.dataGridViewGroups.Size = new System.Drawing.Size(499, 347);
            this.dataGridViewGroups.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Chọn ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dtgvNameGroup
            // 
            this.dtgvNameGroup.HeaderText = "Tên Nhóm";
            this.dtgvNameGroup.MinimumWidth = 6;
            this.dtgvNameGroup.Name = "dtgvNameGroup";
            this.dtgvNameGroup.Width = 200;
            // 
            // dtgvIDNhom
            // 
            this.dtgvIDNhom.HeaderText = "ID";
            this.dtgvIDNhom.MinimumWidth = 6;
            this.dtgvIDNhom.Name = "dtgvIDNhom";
            this.dtgvIDNhom.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPostCount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelGroupCount);
            this.panel2.Controls.Add(this.btnGetPosts);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridViewGroups);
            this.panel2.Controls.Add(this.btnGetGroups);
            this.panel2.Location = new System.Drawing.Point(11, 134);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 427);
            this.panel2.TabIndex = 3;
            // 
            // lblPostCount
            // 
            this.lblPostCount.AutoSize = true;
            this.lblPostCount.Location = new System.Drawing.Point(149, 398);
            this.lblPostCount.Name = "lblPostCount";
            this.lblPostCount.Size = new System.Drawing.Size(14, 16);
            this.lblPostCount.TabIndex = 7;
            this.lblPostCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Post Từ Các Nhóm:";
            // 
            // labelGroupCount
            // 
            this.labelGroupCount.AutoSize = true;
            this.labelGroupCount.Location = new System.Drawing.Point(81, 364);
            this.labelGroupCount.Name = "labelGroupCount";
            this.labelGroupCount.Size = new System.Drawing.Size(14, 16);
            this.labelGroupCount.TabIndex = 4;
            this.labelGroupCount.Text = "0";
            // 
            // btnGetPosts
            // 
            this.btnGetPosts.Location = new System.Drawing.Point(193, 357);
            this.btnGetPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetPosts.Name = "btnGetPosts";
            this.btnGetPosts.Size = new System.Drawing.Size(132, 32);
            this.btnGetPosts.TabIndex = 4;
            this.btnGetPosts.Text = "Lấy Post";
            this.btnGetPosts.UseVisualStyleBackColor = true;
            this.btnGetPosts.Click += new System.EventHandler(this.btnGetPosts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số Nhóm : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Token : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 534);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kết Quả";
            // 
            // txtKetQuaCmt
            // 
            this.txtKetQuaCmt.Location = new System.Drawing.Point(616, 479);
            this.txtKetQuaCmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQuaCmt.Multiline = true;
            this.txtKetQuaCmt.Name = "txtKetQuaCmt";
            this.txtKetQuaCmt.Size = new System.Drawing.Size(404, 47);
            this.txtKetQuaCmt.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 592);
            this.Controls.Add(this.txtKetQuaCmt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Tool Spams Comment FaceBook Groups";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPostCmt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.Button btnGetGroups;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelGroupCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvNameGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvIDNhom;
        private System.Windows.Forms.Button btnGetPosts;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPostCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKetQuaCmt;
    }
}

