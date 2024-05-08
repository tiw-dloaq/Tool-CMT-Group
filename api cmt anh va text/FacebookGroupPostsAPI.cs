using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace api_cmt_anh_va_text
{
    public class FacebookGroupPostsAPI
    {
        private readonly RestClient _client;

        public FacebookGroupPostsAPI()
        {
            _client = new RestClient("https://graph.facebook.com/v19.0");
        }

        public List<string> GetGroupPostIds(string groupId, string accessToken)
        {
            // Tạo URL API để lấy bài viết từ nhóm dựa trên groupId và token
            string url = $"/{groupId}?fields=feed.limit(5)&access_token={accessToken}";

            var request = new RestRequest(url, Method.Get);

            var response = _client.Execute(request);
            var jsonResponse = response.Content;

            var facebookGroupResponse = JsonConvert.DeserializeObject<FacebookGroupResponse>(jsonResponse);

            if (facebookGroupResponse?.Feed != null && facebookGroupResponse.Feed.Data != null && facebookGroupResponse.Feed.Data.Count > 0)
            {
                var postIds = new List<string>();
                foreach (var post in facebookGroupResponse.Feed.Data)
                {
                    postIds.Add(post.Id);
                }
                return postIds;
            }
            else
            {
                return new List<string>();
            }
        }
    }

    public class FacebookGroupResponse
    {
        [JsonProperty("feed")]
        public FeedData Feed { get; set; }
    }

    public class FeedData
    {
        [JsonProperty("data")]
        public List<PostData> Data { get; set; }
    }

    public class PostData
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
