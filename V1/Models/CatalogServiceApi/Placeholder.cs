using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Placeholder
    {
        [JsonProperty("dom_id")]
        public List<string> DomId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("printable")]
        public bool Printable { get; set; }

        [JsonProperty("images")]
        public List<object> Images { get; set; }

        [JsonProperty("front")]
        public Front Front { get; set; }

        [JsonProperty("left_sleeve")]
        public LeftSleeve LeftSleeve { get; set; }

        [JsonProperty("neck")]
        public Neck Neck { get; set; }

        [JsonProperty("right_sleeve")]
        public RightSleeve RightSleeve { get; set; }

        [JsonProperty("back")]
        public Back Back { get; set; }

        [JsonProperty("neck_outer")]
        public NeckOuter NeckOuter { get; set; }
    }

}