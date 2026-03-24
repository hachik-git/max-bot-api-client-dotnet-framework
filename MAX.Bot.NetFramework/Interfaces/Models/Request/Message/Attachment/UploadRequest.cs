namespace MAX.Bot.Interfaces.Models.Request
{
    public enum UploadType
    {
        Image,
        Video,
        Audio,
        File,
    }

    public class UploadRequest
    {
        public string UploadUrl { get; set; }
        public string Token { get; set; }
    }
}
