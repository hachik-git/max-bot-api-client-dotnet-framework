namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment
{

    public sealed class InlineKeyboardAttachment : Attachment
    {
        public override string Type => "inline_keyboard";
        public new InlineKeyboardPayload Payload { get; set; } = new InlineKeyboardPayload();
    }
}