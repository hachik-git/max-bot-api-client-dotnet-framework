using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Response
{
    /// <summary>
    /// Модель ответа от АПИ на получение участникова чата
    /// </summary>
    public class GetChatMembersResponse
    {
        /// <summary>
        /// Список участников чата с информацией о времени последней активности
        /// </summary>
        [JsonProperty("members")]
        public ChatMember[] Members { get; set; }

        /// <summary>
        /// Указатель на следующую страницу данных
        /// </summary>
        [JsonProperty("marker")]
        public long? Marker { get; set; }
    }

}