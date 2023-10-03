using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Uploads
{
    public abstract class ImageUploadRequest
    {
        [JsonProperty("file_name")]
        public string FileName { get; set; }
    }
}
