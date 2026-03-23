using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Response
{
    public class GetUploadUrlResponse
    {
        [JsonProperty("url")]
        public string UploadUrl { get; set; }
        
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
