namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment
{

    public sealed class ImageAttachment : Attachment
    {
        public override string Type => "image";
        public new ImagePayload Payload { get; set; } = new ImagePayload();
    }
}