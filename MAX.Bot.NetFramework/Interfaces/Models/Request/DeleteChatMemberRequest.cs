using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Request
{
    /// <summary>
    /// Модель запроса на удаление пользователя из чата
    /// </summary>
    public class DeleteChatMemberRequest
    {
        /// <summary>
        /// ID чата
        /// </summary>
        [JsonProperty("chatId")]
        public long ChatId { get; set; }

        /// <summary>
        /// ID пользователя, которого нужно удалить из чата
        /// </summary>
        [JsonProperty("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// Если установлено в true, пользователь будет заблокирован в чате
        /// Применяется только для чатов с публичной или приватной ссылкой
        /// Игнорируется в остальных случаях
        /// </summary>
        [JsonProperty("block")]
        public bool? Block { get; set; }
    }
}