namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment;

public sealed class LocationAttachment : Attachment
{
    public new LocationPayload Payload { get; set; } = new();
}