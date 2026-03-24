using MAX.Bot.Interfaces.Models.Request.Message.Attachment.Payloads;

namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment
{
    public sealed class AudioAttachment : Attachment
    {
        public override string Type => "audio";
        public new AudioPayload Payload { get; set; } = new AudioPayload();
    }
}