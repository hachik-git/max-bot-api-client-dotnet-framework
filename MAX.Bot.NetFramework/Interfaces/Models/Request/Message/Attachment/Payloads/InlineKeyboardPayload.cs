using MAX.Bot.Interfaces.Models.Request.Message.Attachment;
using Newtonsoft.Json;
using System.Collections.Generic;

public sealed class InlineKeyboardPayload : AttachmentPayload
{
    public override string Type => "inline_keyboard";

    [JsonProperty("buttons")]
    public List<List<Button>> Buttons { get; set; }
}

public abstract class Button
{
    public abstract string Type { get; }
}

public sealed class CallbackButton : Button
{
    public override string Type => "callback";

    /// <summary>
    /// от 1 до 128 символовВидимый текст кнопки.
    /// Чтобы он отображался полностью, рекомендуем не превышать заданное количество символов в зависимости от размещения текста: 20 символов — при 1 кнопке в ряду, 10 — при 2, 5 — при 3, 3 — при 4
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; }

    /// <summary>
    /// до 1024 символов
    /// Токен кнопки
    /// </summary>
    [JsonProperty("payload")]
    public string Payload { get; set; }
}

public sealed class LinkButton : Button
{
    public override string Type => "link";

    /// <summary>
    /// от 1 до 128 символовВидимый текст кнопки.
    /// Чтобы он отображался полностью, рекомендуем не превышать заданное количество символов в зависимости от размещения текста: 20 символов — при 1 кнопке в ряду, 10 — при 2, 5 — при 3, 3 — при 4
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; }

    /// <summary>
    /// до 2048 символов
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }
}

public sealed class RequestGeoButton : Button
{
    public override string Type => "request_geo_location";

    /// <summary>
    /// от 1 до 128 символовВидимый текст кнопки.
    /// Чтобы он отображался полностью, рекомендуем не превышать заданное количество символов в зависимости от размещения текста: 20 символов — при 1 кнопке в ряду, 10 — при 2, 5 — при 3, 3 — при 4
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; }

    /// <summary>
    /// Если true, отправляет местоположение без запроса подтверждения пользователя
    /// </summary>
    [JsonProperty("quick")]
    public bool Quick { get; set; }
}

public sealed class RequestContactButton : Button
{
    public override string Type => "request_contact";

    /// <summary>
    /// от 1 до 128 символовВидимый текст кнопки.
    /// Чтобы он отображался полностью, рекомендуем не превышать заданное количество символов в зависимости от размещения текста: 20 символов — при 1 кнопке в ряду, 10 — при 2, 5 — при 3, 3 — при 4
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; }
}

public sealed class OpenAppButton : Button
{
    public override string Type => "open_app";

    /// <summary>
    /// от 1 до 128 символовВидимый текст кнопки.
    /// Чтобы он отображался полностью, рекомендуем не превышать заданное количество символов в зависимости от размещения текста: 20 символов — при 1 кнопке в ряду, 10 — при 2, 5 — при 3, 3 — при 4
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; }

    /// <summary>
    /// Публичное имя (username) бота или ссылка на него, чьё мини-приложение надо запустить
    /// </summary>
    [JsonProperty("web_app")]
    public string WebApp { get; set; }

    /// <summary>
    /// Идентификатор бота, чьё мини-приложение надо запустить
    /// </summary>
    [JsonProperty("contact_id")]
    public long? ContactId { get; set; }

    /// <summary>
    /// Параметр запуска, который будет передан в initData мини-приложения
    /// </summary>
    [JsonProperty("payload")]
    public string Payload { get; set; }
}

public sealed class MessageButton : Button
{
    public override string Type => "message";

    /// <summary>
    /// от 1 до 128 символовВидимый текст кнопки.
    /// Чтобы он отображался полностью, рекомендуем не превышать заданное количество символов в зависимости от размещения текста: 20 символов — при 1 кнопке в ряду, 10 — при 2, 5 — при 3, 3 — при 4
    /// </summary>
    [JsonProperty("text")]
    public string Text { get; set; }
}