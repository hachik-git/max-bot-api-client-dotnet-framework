using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Request
{
    /// <summary>
    /// Модель запроса на получение участников чата
    /// </summary>
    public class GetChatMembersRequest
    {
        /// <summary>
        /// ID чата
        /// </summary>
        [JsonProperty("chatId")]
        public long? ChatId { get; set; }

        /// <summary>
        /// Список ID пользователей, чье членство нужно получить. 
        /// Когда этот параметр передан, параметры count и marker игнорируются
        /// </summary>
        [JsonProperty("user_ids")]
        public long[] UserIds { get; set; }

        /// <summary>
        /// Указатель на следующую страницу данных
        /// </summary>
        [JsonProperty("marker")]
        public long? Marker { get; set; }

        /// <summary>
        /// По умолчанию: "20"
        /// Количество участников, которых нужно вернуть
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }

}