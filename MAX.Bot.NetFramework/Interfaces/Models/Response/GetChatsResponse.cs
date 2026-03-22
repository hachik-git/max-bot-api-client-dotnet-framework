using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Response
{
    /// <summary>
    /// Модель ответа от АПИ на получение чатов
    /// </summary>
    public class GetChatsResponse
    {
        /// <summary>
        /// Список запрашиваемых чатов
        /// </summary>
        [JsonProperty("chats")]
        public Chat[] Chats { get; set; }

        /// <summary>
        /// Указатель на следующую страницу запрашиваемых чатов
        /// </summary>
        [JsonProperty("marker")]
        public long? Marker { get; set; }
    }
}