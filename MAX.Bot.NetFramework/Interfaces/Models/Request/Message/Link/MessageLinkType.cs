using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MAX.Bot.Interfaces.Models.Request.Message.Link
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageLinkType
    {
        Forward,
        Reply
    }
}