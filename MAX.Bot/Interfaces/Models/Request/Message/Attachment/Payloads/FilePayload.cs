using System.Text.Json.Serialization;
using MAX.Bot.Interfaces.Models.Request.Message.Attachment;

/// <summary>
/// Это информация, которую вы получите, как только аудио/видео будет загружено
/// </summary>
public sealed class FilePayload: AttachmentPayload
{
    /// <summary>
    /// Токен — уникальный ID загруженного медиафайла
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }
}