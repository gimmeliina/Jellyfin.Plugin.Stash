using Newtonsoft.Json;

namespace Stash.Models
{
    public struct Group
    {
        [JsonProperty(PropertyName = "front_image_path")]
        public string FrontImagePath { get; set; }

        [JsonProperty(PropertyName = "director")]
        public string Director { get; set; }
    }
}
