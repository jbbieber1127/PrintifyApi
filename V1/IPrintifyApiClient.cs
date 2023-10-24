using PrintifyApi.V1.Models;
using PrintifyApi.V1.Models.Catalog.Blueprints;
using PrintifyApi.V1.Models.Catalog.Blueprints.ShippingInformation;
using PrintifyApi.V1.Models.Shops;
using PrintifyApi.V1.Models.Shops.Orders;
using PrintifyApi.V1.Models.Shops.Orders.Create;
using PrintifyApi.V1.Models.Shops.Products;
using PrintifyApi.V1.Models.Shops.Webhooks;
using PrintifyApi.V1.Models.Uploads;

namespace PrintifyApi.V1
{
    public interface IPrintifyApiClient
    {
        Task ArchiveUploadedImageAsync(string uploadId);
        Task<ShippingCostResponse> CalculateShippingCostAsync(int shopId, ShippingRequest order);
        Task<InitiatedOrder> CancelOrder(int shopId, string orderId);
        Task<Product> CreateProductAsync(int shopId, Product product);
        Task<Webhook> CreateWebhookAsync(int shopId, WebhookCreateRequest webhookCreateRequest);
        void DeleteProduct(int shopId, string productId);
        Task DeleteWebhookAsync(int shopId, string webhookId);
        void DisconnectShopAsync(int shopId);
        Task<Blueprint> GetBlueprintAsync(int blueprintId);
        Task<List<PrintProvider>> GetBlueprintPrintProvidersAsync(int blueprintId);
        Task<List<Blueprint>> GetBlueprintsAsync();
        Task<ShippingInformation> GetBlueprintShippingInformationAsync(int blueprintId, int printProviderId);
        Task<VariantsResponse> GetBlueprintVariantsAsync(int blueprintId, int printProviderId, bool showOutOfStock = false);
        Task<Order> GetOrderAsync(int shopId, string orderId);
        Task<PaginatedResponse<Order>> GetOrdersAsync(int shopId, int limit = 10, int page = 0, string status = "", string sku = "");
        Task<PrintProvider> GetPrintProviderAsync(int print_provider_id);
        Task<List<PrintProvider>> GetPrintProvidersAsync();
        Task<Product> GetProductAsync(int shopId, string productId);
        Task<PaginatedResponse<Product>> GetProductsAsync(int shopId, int limit = 10, int page = 0);
        Task<List<Shop>> GetShopsAsync();
        Task<ImageUpload> GetUploadAsync(string uploadId);
        Task<PaginatedResponse<ImageUpload>> GetUploadsAsync(int limit = 10, int page = 0);
        Task<List<Webhook>> GetWebhooksAsync(int shopId);
        Task<PostOrderResponse> PostOrderAsync(int shopId, OrderRequest order);
        Task<InitiatedOrder> PostOrderToProductionAsync(int shopId, string orderId);
        Task PublishProductAsync(int shopId, string productId, PublishProductRequest publishProductRequest);
        Task PublishProductFailedAsync(int shopId, string productId, PublishProductFailedRequest publishProductFailedRequest);
        Task PublishProductSucceededAsync(int shopId, string productId, PublishProductSucceededRequest publishProductSucceededRequest);
        Task UnpublishProductAsync(int shopId, string productId);
        Task<Product> UpdateProductAsync(int shopId, Product product);
        Task<Webhook> UpdateWebhookAsync(int shopId, string webhookId, WebhookUpdateRequest webhookUpdateRequest);
        Task<ImageUpload> UploadImageAsync(ImageContentUploadRequest imageUploadRequest);
        Task<ImageUpload> UploadImageAsync(ImageUrlUploadRequest imageUploadRequest);
    }
}