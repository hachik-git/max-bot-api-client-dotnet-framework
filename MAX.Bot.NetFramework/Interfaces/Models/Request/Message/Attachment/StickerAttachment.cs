using MAX.Bot.Interfaces.Models.Request.Message.Attachment.Payloads;

namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment
{
    public sealed class StickerAttachment : Attachment
    {
        public override string Type => "sticker";
        public new StickerPayload Payload { get; set; } = new StickerPayload();
    }
}