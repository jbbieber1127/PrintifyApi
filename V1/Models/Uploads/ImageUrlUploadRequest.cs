using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Uploads
{
    public class ImageUrlUploadRequest : ImageUploadRequest
    {

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
