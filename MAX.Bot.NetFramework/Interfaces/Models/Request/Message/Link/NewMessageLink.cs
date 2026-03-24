using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Request.Message.Link
{
    public class NewMessageLink
    {
        /// <summary>
        /// Enum: "forward" "reply"
        /// Тип ссылки сообщения
        /// </summary>
        [JsonProperty("type")]
        public MessageLinkType Type { get; set; }

        /// <summary>
        /// ID сообщения исходного сообщения
        /// </summary>
        [JsonProperty("mid")]
        public string MId { get; set; }
    }
}