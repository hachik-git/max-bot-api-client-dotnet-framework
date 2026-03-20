namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment;

public sealed class StickerAttachment : Attachment
{
    public new StickerPayload Payload { get; set; } = new();
}