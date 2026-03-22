using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Response
{
    /// <summary>
    /// Модель ответа от АПИ на получение сообщений
    /// </summary>
    public class GetMessagesResponse
    {
        /// <summary>
        /// Массив сообщений
        /// </summary>
        [JsonProperty("messages")]
        public Message[] Messages { get; set; }
    }
}