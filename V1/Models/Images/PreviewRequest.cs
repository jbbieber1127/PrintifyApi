namespace PrintifyApi.V1.Models.Images
{
    // may want to inherit from image class in uploads
    public class Image
    {
        public double scale { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public int angle { get; set; }
        public bool flipX { get; set; }
        public bool flipY { get; set; }
        public string layerType { get; set; }
        public string type { get; set; }
        public string color { get; set; }
        public string name { get; set; }
        public string textAlign { get; set; }
        public string id { get; set; }
        public string fontFamily { get; set; }
        public int fontWeight { get; set; }
        public int lineHeight { get; set; }
        public int baselineFontSize { get; set; }
        public string textInput { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Placeholder
    {
        public List<string> dom_id { get; set; }
        public string position { get; set; }
        public int sequence { get; set; }
        public bool printable { get; set; }
        public List<Image> images { get; set; }
    }

    public class Print
    {
        public List<Placeholder> placeholders { get; set; }
        public bool print_on_side { get; set; }
        public bool mirror { get; set; }
        public bool canvas { get; set; }
        public string font_color { get; set; }
        public string country { get; set; }
    }

    public class PreviewRequest
    {
        public Print print { get; set; }
        public int decorator_id { get; set; }
        public int camera_id { get; set; }
        public int variant_id { get; set; }
        public int size { get; set; }
        public int blueprint_id { get; set; }
        public string mockup_mode { get; set; }
        public string format { get; set; }
    }


}
