using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Uploads
{
    public class ImageContentUploadRequest : ImageUploadRequest
    {
        [JsonProperty("contents")]
        public string Contents { get; set; }
    }
}
