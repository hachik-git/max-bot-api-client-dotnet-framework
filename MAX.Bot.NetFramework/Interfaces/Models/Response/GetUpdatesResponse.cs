using Newtonsoft.Json;
using System.Collections.Generic;

namespace MAX.Bot.Interfaces.Models.Response
{

    /// <summary>
    /// Модель ответа от АПИ на получение обновлений
    /// </summary>
    public class GetUpdatesResponse
    {
        /// <summary>
        /// Страница обновлений
        /// </summary>
        [JsonProperty("updates")]
        public System.Collections.Generic.List<Update> Updates { get; set; } = new List<Update>();

        /// <summary>
        /// Указатель на следующую страницу данных
        /// </summary>
        [JsonProperty("marker")]
        public long? Marker { get; set; }
    }
}