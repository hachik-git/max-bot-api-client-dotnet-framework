using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Request
{
    /// <summary>
    /// Модель запроса на получение чатов
    /// </summary>
    public class GetChatsRequest
    {
        /// <summary>
        /// По умолчанию: 50
        /// Количество запрашиваемых чатов
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Указатель на следующую страницу данных. 
        /// Для первой страницы передайте null
        /// </summary>
        [JsonProperty("marker")]
        public long? Marker { get; set; }
    }
}