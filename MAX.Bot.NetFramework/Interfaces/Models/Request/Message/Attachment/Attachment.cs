using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Request.Message.Attachment
{
    public abstract class Attachment
    {
        [JsonProperty("type")]
        public abstract string Type { get; }

        [JsonProperty("payload")]
        public AttachmentPayload Payload { get; set; }
    }

    public abstract class AttachmentPayload
    {
        [JsonProperty("type")]
        public abstract string Type { get; }
    }

    public interface IMediaPayload { };
}