using MAX.Bot.Interfaces.Models.Request.Message.Attachment;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MAX.Bot.Interfaces.Models.Response
{
    public class MediaUploadResponse<T>
        where T : AttachmentPayload, IMediaPayload
    {
        [JsonProperty("photos")]
        public Dictionary<string, T> Photos { get; set; }
    }
}
