using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PrintifyApi.V1.Models.CatalogServiceApi{ 

    public class Root
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("blueprint_id")]
        public int BlueprintId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("brand")]
        public Brand Brand { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("details")]
        public List<Detail> Details { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }

        [JsonProperty("careSets")]
        public List<CareSet> CareSets { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("render_settings")]
        public RenderSettings RenderSettings { get; set; }

        [JsonProperty("enabled")]
        public int Enabled { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("variants_changeable")]
        public int VariantsChangeable { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("hidden_tags")]
        public List<string> HiddenTags { get; set; }

        [JsonProperty("guidelines")]
        public List<object> Guidelines { get; set; }

        [JsonProperty("seo")]
        public Seo Seo { get; set; }

        [JsonProperty("tax_category_id")]
        public string TaxCategoryId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("templates")]
        public List<object> Templates { get; set; }

        [JsonProperty("fakeweight")]
        public double Fakeweight { get; set; }

        [JsonProperty("catalog_print_area_group")]
        public string CatalogPrintAreaGroup { get; set; }

        [JsonProperty("catalog_print_area_method")]
        public string CatalogPrintAreaMethod { get; set; }

        [JsonProperty("pricing_print_area")]
        public string PricingPrintArea { get; set; }

        [JsonProperty("sizeGuide")]
        public SizeGuide SizeGuide { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("print_provider")]
        public PrintProvider PrintProvider { get; set; }
    }

}