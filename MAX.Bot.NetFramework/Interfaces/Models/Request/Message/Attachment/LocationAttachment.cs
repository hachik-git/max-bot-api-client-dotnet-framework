namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment
{

    public sealed class LocationAttachment : Attachment
    {
        public override string Type => "location";
        public new LocationPayload Payload { get; set; } = new LocationPayload();
    }
}