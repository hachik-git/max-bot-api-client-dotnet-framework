using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MAX.Bot.Interfaces.Models
{
    /// <summary>
    /// Формат сообщения
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageFormat
    {
        /// <summary>
        /// Markdown разметка
        /// </summary>
        Markdown,

        /// <summary>
        /// HTML разметка
        /// </summary>
        Html
    }
}