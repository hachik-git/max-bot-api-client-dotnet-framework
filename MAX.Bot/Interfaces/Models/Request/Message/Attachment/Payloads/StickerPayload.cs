using System.Text.Json.Serialization;
using MAX.Bot.Interfaces.Models.Request.Message.Attachment;

public sealed class StickerPayload : AttachmentPayload
{
    /// <summary>
    /// Код стикера
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }
}