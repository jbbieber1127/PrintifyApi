namespace PrintifyApi.V1.Models.Shops.Webhooks
{
    public class Webhook
    {
        string Id { get; set; }
        int ShopId { get; set; }
        string Topic { get; set; }
        string Url { get; set; }
    }
}
