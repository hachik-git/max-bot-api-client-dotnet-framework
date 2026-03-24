using MAX.Bot.Interfaces.Models.Request.Message.Attachment.Payloads;

namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment
{
    public sealed class VideoAttachment : Attachment
    {
        public override string Type => "video";
        public new VideoPayload Payload { get; set; } = new VideoPayload();
    }
}