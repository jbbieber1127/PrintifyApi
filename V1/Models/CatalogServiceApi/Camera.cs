using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Camera
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("is_default")]
        public int IsDefault { get; set; }

        [JsonProperty("option_id")]
        public object OptionId { get; set; }

        [JsonProperty("variant_id")]
        public object VariantId { get; set; }

        [JsonProperty("custom_background")]
        public bool CustomBackground { get; set; }

        [JsonProperty("blender_file_id")]
        public int BlenderFileId { get; set; }

        [JsonProperty("blender_file_mongo_id")]
        public string BlenderFileMongoId { get; set; }

        [JsonProperty("blender_json")]
        public BlenderJson BlenderJson { get; set; }

        [JsonProperty("placeholders")]
        public JObject Placeholders { get; set; }

        [JsonProperty("camera_id")]
        public int CameraId { get; set; }
    }

}