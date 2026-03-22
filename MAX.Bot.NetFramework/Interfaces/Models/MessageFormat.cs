using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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