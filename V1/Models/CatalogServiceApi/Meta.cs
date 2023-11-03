using Newtonsoft.Json; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Meta
    {
        [JsonProperty("type")]
        public Type Type { get; set; }

        [JsonProperty("sla")]
        public int Sla { get; set; }
    }

}