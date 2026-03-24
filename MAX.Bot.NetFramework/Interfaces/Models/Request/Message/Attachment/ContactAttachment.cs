using MAX.Bot.Interfaces.Models.Request.Message.Attachment.Payloads;

namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment
{
    public sealed class ContactAttachment : Attachment
    {
        public override string Type => "contact";
        public new ContactPayload Payload { get; set; } = new ContactPayload();
    }
}