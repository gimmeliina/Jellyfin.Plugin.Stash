using Newtonsoft.Json;

namespace Stash.Models
{
    public struct Groups
    {
        [JsonProperty(PropertyName = "group")]
        public Group Group { get; set; }
    }
}
