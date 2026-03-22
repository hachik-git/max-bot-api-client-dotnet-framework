using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models
{

    /// <summary>
    /// Модель чата
    /// </summary>
    public class Chat
    {
        /// <summary>
        /// ID чата
        /// </summary>
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        /// <summary>
        /// Тип чата
        /// "chat" — Групповой чат
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Статус чата
        /// "active" — Бот является активным участником чата
        /// "removed" — Бот был удалён из чата
        /// "left" — Бот покинул чат
        /// "closed" — Чат был закрыт
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Отображаемое название чата
        /// Может быть null для диалогов
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Иконка чата
        /// </summary>
        [JsonProperty("icon")]
        public Image Icon { get; set; }

        /// <summary>
        /// Время последнего события в чате
        /// </summary>
        [JsonProperty("last_event_time")]
        public long LastEventTime { get; set; }

        /// <summary>
        /// Количество участников чата
        /// Для диалогов всегда 2
        /// </summary>
        [JsonProperty("participants_count")]
        public int ParticipantsCount { get; set; }

        /// <summary>
        /// ID владельца чата
        /// </summary>
        [JsonProperty("owner_id")]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Участники чата с временем последней активности
        /// Может быть null, если запрашивается список чатов
        /// </summary>
        [JsonProperty("participants")]
        public object Participants { get; set; }

        /// <summary>
        /// Доступен ли чат публично
        /// Для диалогов всегда false
        /// </summary>
        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// Ссылка на чат
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Описание чата
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Данные о пользователе в диалоге
        /// Только для чатов типа "dialog"
        /// </summary>
        [JsonProperty("dialog_with_user")]
        public User DialogWithUser { get; set; }

        /// <summary>
        /// ID сообщения, содержащего кнопку, через которую был инициирован чат
        /// </summary>
        [JsonProperty("chat_message_id")]
        public string ChatMessageId { get; set; }

        /// <summary>
        /// Закреплённое сообщение в чате
        /// Возвращается только при запросе конкретного чата
        /// </summary>
        [JsonProperty("pinned_message")]
        public Message PinnedMessage { get; set; }
    }

    /// <summary>
    /// Статус чата
    /// </summary>
    public static class ChatStatus
    {
        /// <summary>
        /// Бот является активным участником чата
        /// </summary>
        public const string Active = "active";

        // <summary>
        /// Бот был удалён из чата
        /// </summary>
        public const string Removed = "removed";

        /// <summary>
        /// Бот покинул чат
        /// </summary>
        public const string Left = "left";

        /// <summary>
        /// Чат был закрыт
        /// </summary>
        public const string Closed = "closed";
    }
}