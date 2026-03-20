namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment;

public sealed class InlineKeyboardAttachment : Attachment
{
    public new InlineKeyboardPayload Payload { get; set; } = new();
}