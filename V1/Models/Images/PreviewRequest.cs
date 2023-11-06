using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Images
{
    // may want to inherit from image class in uploads
    public class Image
    {
        [JsonProperty("scale")]
        public double Scale { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("angle")]
        public int Angle { get; set; }
        [JsonProperty("flipX")]
        public bool FlipX { get; set; }

        [JsonProperty("flipY")]
        public bool FlipY { get; set; }
        [JsonProperty("layerType")]
        public string LayerType { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("textAlign")]
        public string TextAlign { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("fontFamily")]
        public string FontFamily { get; set; }
        [JsonProperty("fontWeight")]
        public int FontWeight { get; set; }
        [JsonProperty("lineHeight")]
        public int LineHeight { get; set; }
        [JsonProperty("baselineFontSize")]
        public int BaselineFontSize { get; set; }
        [JsonProperty("textInput")]
        public string TextInput { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
    }

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
        public List<Image> Images { get; set; }
    }

    public class Print
    {
        [JsonProperty("placeholders")]
        public List<Placeholder> Placeholders { get; set; }
        [JsonProperty("print_on_side")]
        public bool PrintOnSide { get; set; }
        [JsonProperty("mirror")]
        public bool Mirror { get; set; }
        [JsonProperty("canvas")]
        public bool Canvas { get; set; }
        [JsonProperty("font_color")]
        public string FontColor { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class PreviewRequest
    {
        [JsonProperty("print")]
        public Print Print { get; set; }
        [JsonProperty("decorator_id")]
        public int DecoratorId { get; set; }
        [JsonProperty("camera_id")]
        public int CameraId { get; set; }
        [JsonProperty("variant_id")]
        public int VariantId { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }
        [JsonProperty("blueprint_id")]
        public int BlueprintId { get; set; }
        [JsonProperty("mockup_mode")]
        public string MockupMode { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
    }


}
