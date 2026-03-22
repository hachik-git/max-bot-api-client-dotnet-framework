using MAX.Bot.Interfaces.Models.Request.Message.Attachment;
using Newtonsoft.Json;

public sealed class LocationPayload : AttachmentPayload
{
    public override string Type => "location";

    /// <summary>
    /// Широта
    /// </summary>
    [JsonProperty("latitude")]
    public double Latitude { get; set; }

    /// <summary>
    /// Долгота
    /// </summary>
    [JsonProperty("longitude")]
    public double Longitude { get; set; }
}