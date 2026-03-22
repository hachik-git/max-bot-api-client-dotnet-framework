using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models.Response
{
    /// <summary>
    /// Стандартный ответ от АПИ
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// true, если запрос был успешным, false в противном случае
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Объяснительное сообщение, если результат не был успешным
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}