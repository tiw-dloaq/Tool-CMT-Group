using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_cmt_anh_va_text
{
    public class GroupData
    {
        public List<Group> data { get; set; }
    }

    public class Group
    {
        public string id { get; set; }
        public string name { get; set; }
        public int member_count { get; set; }
    }
}
