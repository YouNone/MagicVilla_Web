using static MagicVilla_Utility.StaticDetails;

namespace MagicVilla_Web.Models
{
    public class APIRequest
    {
        // RCl => Add => add prject ref => MagicVilla_Utility
        public ApiType ApiType { get; set; } = ApiType.GET;

        public string Url { get; set; }
        public object Data { get; set; }
    }
}
