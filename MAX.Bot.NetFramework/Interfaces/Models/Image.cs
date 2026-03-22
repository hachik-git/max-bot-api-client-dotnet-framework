using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models
{

    /// <summary>
    /// Модель изображения
    /// </summary>
    public class Image
    {
        /// <summary>
        /// URL изображения
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}