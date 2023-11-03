using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class BlenderJson
    {
        [JsonProperty("lens")]
        public int Lens { get; set; }

        [JsonProperty("lens_unit")]
        public string LensUnit { get; set; }

        [JsonProperty("location")]
        public List<double> Location { get; set; }

        [JsonProperty("rotation_euler")]
        public List<double> RotationEuler { get; set; }

        [JsonProperty("sensor_fit")]
        public string SensorFit { get; set; }

        [JsonProperty("sensor_height")]
        public int SensorHeight { get; set; }

        [JsonProperty("sensor_width")]
        public int SensorWidth { get; set; }

        [JsonProperty("shift_x")]
        public int ShiftX { get; set; }

        [JsonProperty("shift_y")]
        public int ShiftY { get; set; }
    }

}