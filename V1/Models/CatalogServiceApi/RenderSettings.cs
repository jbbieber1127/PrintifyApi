using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class RenderSettings
    {
        [JsonProperty("cameras")]
        public List<Camera> Cameras { get; set; }

        [JsonProperty("settings")]
        public List<object> Settings { get; set; }
    }

}