using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models
{
    /// <summary>
    /// Модель тела сообщения
    /// </summary>
    public class MessageBody
    {
        /// <summary>
        /// Уникальный ID сообщения
        /// </summary>
        [JsonProperty("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// Новый текст сообщения
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}