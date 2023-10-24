using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.CatalogServiceApi;

public class BlueprintDetails
{
    [JsonProperty("blueprintId")]
    public int BlueprintId { get; set; }

    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("brandName")]
    public string BrandName { get; set; }

    [JsonProperty("careSets")]
    public List<CareSet> CareSets { get; set; }

    [JsonProperty("printProviders")]
    public List<PrintProvider> PrintProviders { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("details")]
    public List<string> Details { get; set; }

    [JsonProperty("features")]
    public List<Feature> Features { get; set; }

    [JsonProperty("hiddenTags")]
    public List<string> HiddenTags { get; set; }

    [JsonProperty("media")]
    public List<Medium> Media { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("model")]
    public string Model { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("custom_mockups")]
    public bool CustomMockups { get; set; }

    [JsonProperty("pricingPrintArea")]
    public string PricingPrintArea { get; set; }

    [JsonProperty("seo")]
    public Seo Seo { get; set; }

    [JsonProperty("sizeGuide")]
    public SizeGuide SizeGuide { get; set; }

    [JsonProperty("tags")]
    public List<string> Tags { get; set; }

    [JsonProperty("managed_tags")]
    public List<ManagedTag> ManagedTags { get; set; }
}