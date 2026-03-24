using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment.Payloads
{
    /// <summary>
    /// Это информация, которую вы получите, как только аудио/видео будет загружено
    /// </summary>
    public sealed class FilePayload : AttachmentPayload
    {
        public override string Type => "file";

        /// <summary>
        /// Токен — уникальный ID загруженного медиафайла
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}