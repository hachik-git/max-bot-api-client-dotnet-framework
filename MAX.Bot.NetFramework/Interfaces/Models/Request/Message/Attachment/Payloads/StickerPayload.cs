using MAX.Bot.Interfaces.Models.Request.Message.Attachment;
using Newtonsoft.Json;

public sealed class StickerPayload : AttachmentPayload
{
    public override string Type => "sticker";

    /// <summary>
    /// Код стикера
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }
}