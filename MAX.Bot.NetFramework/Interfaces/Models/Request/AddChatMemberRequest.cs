using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Request
{

    /// <summary>
    /// Модель запроса на добавление пользователя в чат
    /// </summary>
    public class AddChatMemberRequest
    {
        /// <summary>
        /// ID чата
        /// </summary>
        [JsonProperty("chatId")]
        public long ChatId { get; set; }

        /// <summary>
        /// Массив ID пользователей для добавления в чат
        /// </summary>
        [JsonProperty("user_ids")]
        public long[] UserIds { get; set; }
    }
}