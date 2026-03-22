using Newtonsoft.Json;
using System.Collections.Generic;

namespace MAX.Bot.Interfaces.Models.Request
{

    /// <summary>
    /// Модель запроса на получение обновлений
    /// </summary>
    public class GetUpdatesRequest
    {
        /// <summary>
        /// Максимальное количество обновлений для получения (1-1000)
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Тайм-аут в секундах для долгого опроса (0-90)
        /// </summary>
        [JsonProperty("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Указатель на следующее ожидаемое обновление
        /// </summary>
        [JsonProperty("marker")]
        public long? Marker { get; set; }

        /// <summary>
        /// Список типов обновлений для фильтрации
        /// </summary>
        [JsonProperty("types")]
        public List<string> Types { get; set; }
    }
}