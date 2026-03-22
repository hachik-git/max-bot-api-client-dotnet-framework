using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Response
{

    /// <summary>
    /// Модель ответа от АПИ на отправку сообщения
    /// </summary>
    public class SendMessageResponse
    {
        /// <summary>
        /// Сообщение в чате
        /// </summary>
        [JsonProperty("message")]
        public Message Message { get; set; }
    }
}