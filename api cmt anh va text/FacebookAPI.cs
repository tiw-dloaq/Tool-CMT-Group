using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_cmt_anh_va_text
{
    public class FacebookAPI
    {
        private readonly RestClient _client;

        public FacebookAPI()
        {
            _client = new RestClient("https://graph.facebook.com/v19.0");
        }

        public string GetJoinedGroups(string accessToken, int limit = 1000)
        {
            var request = new RestRequest("me/groups", Method.Get);
            request.AddParameter("fields", "id,name,member_count");
            request.AddParameter("access_token", accessToken);
            request.AddParameter("limit", limit); // Thêm trường limit vào yêu cầu

            var response = _client.Execute(request);
            return response.Content;
        }
    }
}
