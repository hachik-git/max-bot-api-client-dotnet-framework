using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
