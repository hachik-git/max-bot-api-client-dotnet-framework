namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment
{

    public sealed class FileAttachment : Attachment
    {
        public new FilePayload Payload { get; set; } = new FilePayload();

        public override string Type => "file";
    }
}