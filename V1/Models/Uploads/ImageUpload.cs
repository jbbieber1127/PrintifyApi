using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Uploads
{
    public class ImageUpload
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("upload_time")]
        public string UploadTime { get; set; }
    }
}
