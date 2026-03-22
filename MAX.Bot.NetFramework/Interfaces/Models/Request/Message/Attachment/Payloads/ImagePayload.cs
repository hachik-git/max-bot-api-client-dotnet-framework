using MAX.Bot.Interfaces.Models.Request.Message.Attachment;
using Newtonsoft.Json;

/// <summary>
/// Запрос на прикрепление изображения (все поля являются взаимоисключающими)
/// </summary>
public sealed class ImagePayload : AttachmentPayload
{
    public override string Type => "image";

    /// <summary>
    /// от 1 символа
    /// Любой внешний URL изображения, которое вы хотите прикрепить
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }

    /// <summary>
    /// Токен существующего вложения
    /// </summary>
    [JsonProperty("token")]
    public string Token { get; set; }

    /// <summary>
    /// Токены, полученные после загрузки изображений
    /// </summary>
    [JsonProperty("photos")]
    public string Photos { get; set; }
}