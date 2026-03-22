using Newtonsoft.Json;

namespace MAX.Bot.Interfaces.Models
{

    /// <summary>
    /// Модель пользователя или бота
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор пользователя или бота
        /// </summary>
        [JsonProperty("user_id")]
        public long Id { get; set; }

        /// <summary>
        /// Отображаемое имя пользователя или бота
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Отображаемая фамилия пользователя.
        /// Для ботов это поле не возвращается (nullable)
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Никнейм бота или уникальное публичное имя пользователя.
        /// В случае с пользователем может быть null, если недоступен или имя не задано
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// true, если это бот
        /// </summary>
        [JsonProperty("is_bot")]
        public bool IsBot { get; set; }

        /// <summary>
        /// Время последней активности пользователя или бота в MAX (Unix-время в миллисекундах).
        /// Если пользователь отключил в настройках профиля мессенджера MAX возможность видеть, 
        /// что он в сети онлайн, поле может не возвращаться
        /// </summary>
        [JsonProperty("last_activity_time")]
        public long? LastActivityTime { get; set; }

        /// <summary>
        /// Описание пользователя или бота (до 16000 символов).
        /// В случае с пользователем может быть null, если описание не заполнено
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// URL аватара пользователя или бота в уменьшенном размере
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// URL аватара пользователя или бота в полном размере
        /// </summary>
        [JsonProperty("full_avatar_url")]
        public string FullAvatarUrl { get; set; }
    }

}