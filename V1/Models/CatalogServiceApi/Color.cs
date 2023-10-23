using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi
{
    public class Color
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        /// <summary>
        /// An identifier referencing an image that Printify uses to display the color.
        /// Ex: If Pattern = "5853fecdce46f30f832820ac", the image url is something like this: https://images.printify.com/api/file/5853fecdce46f30f832820ac
        /// </summary>
        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }
    }
}
