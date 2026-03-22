using MAX.Bot.Interfaces.Models.Request.Message.Link;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MAX.Bot.Interfaces.Models.Request.Message
{

    /// <summary>
    /// Модель запроса на отправку сообщения
    /// </summary>
    public class SendMessageRequest
    {
        /// <summary>
        /// ID пользователя для отправки личного сообщения
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// ID чата для отправки сообщения в группу
        /// </summary>
        [JsonProperty("chat_id")]
        public long? ChatId { get; set; }

        /// <summary>
        /// Отключение предпросмотра ссылок в сообщении
        /// </summary>
        [JsonProperty("disable_link_preview")]
        public bool? DisableLinkPreview { get; set; }

        /// <summary>
        /// Текст сообщения (до 4000 символов)
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Вложения сообщения. Если пусто, все вложения будут удалены
        /// </summary>
        [JsonProperty("attachments")]
        public List<Attachment.Attachment> Attachments { get; set; }

        /// <summary>
        /// Ссылка на сообщение
        /// </summary>
        [JsonProperty("link")]
        public NewMessageLink Link { get; set; }

        /// <summary>
        /// Уведомлять ли участников чата о сообщении
        /// По умолчанию: true
        /// </summary>
        [JsonProperty("notify")]
        public bool? Notify { get; set; } = true;

        /// <summary>
        /// Форматирование текста сообщения
        /// </summary>
        [JsonProperty("format")]
        public MessageFormat? Format { get; set; }
    }
}