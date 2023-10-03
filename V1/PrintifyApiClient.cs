using PrintifyApi.V1.Models;
using PrintifyApi.V1.Models.Catalog.Blueprints;
using PrintifyApi.V1.Models.Catalog.Blueprints.ShippingInformation;
using PrintifyApi.V1.Models.Shops;
using PrintifyApi.V1.Models.Shops.Orders;
using PrintifyApi.V1.Models.Shops.Orders.Create;
using PrintifyApi.V1.Models.Shops.Products;
using PrintifyApi.V1.Models.Shops.Webhooks;
using PrintifyApi.V1.Models.Uploads;
using System.Collections.Specialized;

namespace PrintifyApi.V1
{
    public class PrintifyApiClient : HttpClient
    {
        public PrintifyApiClient(string baseUrl, string apiKey)
        {
            BaseAddress = new Uri(baseUrl);
            DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
        }

        #region Catalog
        /// <summary>
        /// Retrieves list of blueprints in the catalog
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-available-blueprints"/>
        /// </summary>
        public async Task<List<Blueprint>> GetBlueprintsAsync()
        {
            string route = "/v1/catalog/blueprints.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Blueprint>>(content);
        }

        /// <summary>
        /// Retrieves a specific blueprint
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-specific-blueprint"/>
        /// </summary>
        public async Task<Blueprint> GetBlueprintAsync(int blueprintId)
        {
            string route = $"/v1/catalog/blueprints/{blueprintId}.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Blueprint>(content);
        }


        /// <summary>
        /// Retrieves a list of variants options for the given Print Provider and Blueprint
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-variants"/>
        /// </summary>
        public async Task<VariantsResponse> GetBlueprintVariantsAsync(int blueprintId, int printProviderId, bool showOutOfStock = false)
        {
            int showOos = showOutOfStock ? 1 : 0;
            string route = $"/v1/catalog/blueprints/{blueprintId}/print_providers/{printProviderId}/variants.json?show-out-of-stock={showOos}";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<VariantsResponse>(content);
        }

        /// <summary>
        /// Retrieves a list of print providers available for the given Blueprint
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-print-providers"/>
        /// </summary>
        public async Task<List<PrintProvider>> GetBlueprintPrintProvidersAsync(int blueprintId)
        {
            string route = $"/v1/catalog/blueprints/{blueprintId}/print_providers.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PrintProvider>>(content);
        }

        /// <summary>
        /// Retrieves shipping information for the given Print Provider and Blueprint
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-variants"/>
        /// </summary>
        public async Task<ShippingInformation> GetBlueprintShippingInformationAsync(int blueprintId, int printProviderId)
        {
            string route = $"/v1/catalog/blueprints/{blueprintId}/print_providers/{printProviderId}/shipping.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ShippingInformation>(content);
        }

        /// <summary>
        /// Retrieves a list of available print providers
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-available-print-providers"/>
        /// </summary>
        public async Task<List<PrintProvider>> GetPrintProvidersAsync()
        {
            string route = $"/v1/catalog/print_providers.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PrintProvider>>(content);
        }

        /// <summary>
        /// Retrieve a specific print provider and a list of associated blueprint offerings
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-specific-print-provider"/>
        /// </summary>
        public async Task<PrintProvider> GetPrintProviderAsync(int print_provider_id)
        {
            string route = $"/v1/catalog/{print_provider_id}.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PrintProvider>(content);
        }

        #endregion

        #region Orders

        /// <summary>
        /// Retrieve a list of orders
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-orders"/>
        /// </summary>
        public async Task<PaginatedResponse<Order>> GetOrdersAsync(int shopId, int limit = 10, int page = 0, string status = "", string sku = "")
        {
            string route = $"/v1/shops/{shopId}/orders.json";
            NameValueCollection queryString = new();
            if (limit > 0)
            {
                queryString.Add("limit", limit.ToString());
            }
            if (page > 0)
            {
                queryString.Add("page", page.ToString());
            }
            if (!string.IsNullOrWhiteSpace(status))
            {
                queryString.Add("status", status);
            }
            if (!string.IsNullOrWhiteSpace(sku))
            {
                queryString.Add("sku", sku);
            }
            if (queryString.Count > 0)
            {
                route += "?" + queryString.ToString();
            }
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PaginatedResponse<Order>>(content);
        }

        /// <summary>
        /// Get order details by ID
        /// <para />
        /// <see href="https://developers.printify.com/#get-order-details-by-id"/>
        /// </summary>
        public async Task<Order> GetOrderAsync(int shopId, string orderId)
        {
            string route = $"/v1/shops/{shopId}/orders/{orderId}.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Order>(content);
        }

        /// <summary>
        /// Order an existing product
        /// <para />
        /// <see href="https://developers.printify.com/#submit-an-order"/>
        /// </summary>
        public async Task<PostOrderResponse> PostOrderAsync(int shopId, OrderRequest order)
        {
            string route = $"/v1/shops/{shopId}/orders.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(order));
            HttpResponseMessage resp = await PostAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PostOrderResponse>(responseContent);
        }

        /// <summary>
        /// Send an existing order to production
        /// <para />
        /// <see href="https://developers.printify.com/#send-an-existing-order-to-production"/>
        /// </summary>
        public async Task<InitiatedOrder> PostOrderToProductionAsync(int shopId, string orderId)
        {
            string route = $"/v1/shops/{shopId}/orders/{orderId}/send_to_production.json";
            HttpResponseMessage resp = await PostAsync(route, null);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InitiatedOrder>(responseContent);
        }

        /// <summary>
        /// Calculate the shipping cost of an order
        /// <para />
        /// <see href="https://developers.printify.com/#calculate-the-shipping-cost-of-an-order"/>
        /// </summary>
        public async Task<ShippingCostResponse> CalculateShippingCostAsync(int shopId, ShippingRequest order)
        {
            string route = $"/v1/shops/{shopId}/orders/shipping.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(order));
            HttpResponseMessage resp = await PostAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ShippingCostResponse>(responseContent);
        }

        /// <summary>
        /// Cancel an order
        /// <para />
        /// <see href="https://developers.printify.com/#cancel-an-order"/>
        /// </summary>
        public async Task<InitiatedOrder> CancelOrder(int shopId, string orderId)
        {
            string route = $"/v1/shops/{shopId}/orders/{orderId}/cancel.json";
            HttpResponseMessage resp = await PostAsync(route, null);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InitiatedOrder>(responseContent);
        }

        #endregion

        #region Shops
        /// <summary>
        /// View the list of existing shops in a Printify account
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-existing-shops"/>
        /// </summary>
        public async Task<List<Shop>> GetShopsAsync()
        {
            string route = "/v1/shops.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Shop>>(content);
        }

        /// <summary>
        /// Disconnect a shop from a Printify account
        /// <para />
        /// <see href="https://developers.printify.com/#disconnect-a-shop"/>
        /// </summary>
        public async void DisconnectShopAsync(int shopId)
        {
            string route = $"/v1/shops/{shopId}/conection.json";
            await DeleteAsync(route);
        }


        #endregion

        #region Products

        /// <summary>
        /// Retrieve a list of products
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-products"/>
        /// </summary>
        public async Task<PaginatedResponse<Product>> GetProductsAsync(int shopId, int limit = 10, int page = 0)
        {
            string route = $"/v1/shops/{shopId}/products.json";
            NameValueCollection queryString = new();
            if (limit > 0)
            {
                queryString.Add("limit", limit.ToString());
            }
            if (page > 0)
            {
                queryString.Add("page", page.ToString());
            }
            if (queryString.Count > 0)
            {
                route += "?" + queryString.ToString();
            }
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PaginatedResponse<Product>>(content);
        }

        /// <summary>
        /// Retrieve a product
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-products"/>
        /// </summary>
        public async Task<Product> GetProductAsync(int shopId, string productId)
        {
            string route = $"/v1/shops/{shopId}/products/{productId}.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(content);
        }

        /// <summary>
        /// Create a product
        /// <para />
        /// <see href="https://developers.printify.com/#create-a-new-product"/>
        /// </summary>
        public async Task<Product> CreateProductAsync(int shopId, Product product)
        {
            string route = $"/v1/shops/{shopId}/products.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(product));
            HttpResponseMessage resp = await PostAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(responseContent);
        }


        /// <summary>
        /// Update a product
        /// <para />
        /// <see href="https://developers.printify.com/#update-a-product"/>
        /// </summary>
        public async Task<Product> UpdateProductAsync(int shopId, Product product)
        {
            string route = $"/v1/shops/{shopId}/products.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(product));
            HttpResponseMessage resp = await PutAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(responseContent);
        }

        /// <summary>
        /// Delete a product
        /// <para />
        /// <see href="https://developers.printify.com/#delete-a-product"/>
        /// </summary>
        public async void DeleteProduct(int shopId, string productId)
        {
            string route = $"/v1/shops/{shopId}/products/{productId}.json";
            await DeleteAsync(route);
        }

        /// <summary>
        /// Publish a product
        /// <para />
        /// <see href="https://developers.printify.com/#create-a-new-product"/>
        /// </summary>
        public async Task PublishProductAsync(int shopId, string productId, PublishProductRequest publishProductRequest)
        {
            string route = $"/v1/shops/{shopId}/products/{productId}/publish.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(publishProductRequest));
            await PostAsync(route, requestContent);
        }

        /// <summary>
        /// Set product publish status to succeeded
        /// <para />
        /// <see href="https://developers.printify.com/#set-product-publish-status-to-succeeded"/>
        /// </summary>
        public async Task PublishProductSucceededAsync(int shopId, string productId, PublishProductSucceededRequest publishProductSucceededRequest)
        {
            string route = $"/v1/shops/{shopId}/products/{productId}/publish.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(publishProductSucceededRequest));
            await PostAsync(route, requestContent);
        }

        /// <summary>
        /// Set product publish status to failed
        /// <para />
        /// <see href="https://developers.printify.com/#set-product-publish-status-to-failed"/>
        /// </summary>
        public async Task PublishProductFailedAsync(int shopId, string productId, PublishProductFailedRequest publishProductFailedRequest)
        {
            string route = $"/v1/shops/{shopId}/products/{productId}/publishing_failed.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(publishProductFailedRequest));
            await PostAsync(route, requestContent);
        }

        /// <summary>
        /// Notify that a product has been unpublished
        /// <para />
        /// <see href="https://developers.printify.com/#notify-that-a-product-has-been-unpublished"/>
        /// </summary>
        public async Task UnpublishProductAsync(int shopId, string productId)
        {
            string route = $"/v1/shops/{shopId}/products/{productId}/unpublish.json";
            await PostAsync(route, null);
        }

        #endregion

        #region Uploads

        /// <summary>
        /// Retrieve a list of uploaded images
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-uploaded-images"/>
        /// </summary>
        public async Task<PaginatedResponse<ImageUpload>> GetUploadsAsync(int limit = 10, int page = 0)
        {
            string route = $"/v1/uploads.json";
            NameValueCollection queryString = new();
            if (limit > 0)
            {
                queryString.Add("limit", limit.ToString());
            }
            if (page > 0)
            {
                queryString.Add("page", page.ToString());
            }
            if (queryString.Count > 0)
            {
                route += "?" + queryString.ToString();
            }
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PaginatedResponse<ImageUpload>>(content);
        }

        /// <summary>
        /// Retrieve an uploaded image by id
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-an-uploaded-image-by-id"/>
        /// </summary>
        public async Task<ImageUpload> GetUploadAsync(string uploadId)
        {
            string route = $"/v1/uploads/{uploadId}.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ImageUpload>(content);
        }

        /// <summary>
        /// Upload an image via url
        /// <para />
        /// <see href="https://developers.printify.com/#create-a-new-product"/>
        /// </summary>
        public async Task<ImageUpload> UploadImageAsync(ImageUrlUploadRequest imageUploadRequest)
        {
            string route = $"/v1/uploads/images.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(imageUploadRequest));
            HttpResponseMessage resp = await PostAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ImageUpload>(responseContent);
        }

        /// <summary>
        /// Upload an image via base-64 encoded content
        /// <para />
        /// <see href="https://developers.printify.com/#create-a-new-product"/>
        /// </summary>
        public async Task<ImageUpload> UploadImageAsync(ImageContentUploadRequest imageUploadRequest)
        {
            string route = $"/v1/uploads/images.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(imageUploadRequest));
            HttpResponseMessage resp = await PostAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ImageUpload>(responseContent);
        }

        /// <summary>
        /// Archive an uploaded image
        /// <para />
        /// <see href="https://developers.printify.com/#create-a-new-product"/>
        /// </summary>
        public async Task ArchiveUploadedImageAsync(string uploadId)
        {
            string route = $"/v1/uploads/{uploadId}/archive.json";
            HttpResponseMessage resp = await PostAsync(route, null);
            await resp.Content.ReadAsStringAsync();
        }

        #endregion

        #region Webhooks

        /// <summary>
        /// Retrieve a list of webhooks
        /// <para />
        /// <see href="https://developers.printify.com/#retrieve-a-list-of-webhooks"/>
        /// </summary>
        public async Task<List<Webhook>> GetWebhooksAsync(int shopId)
        {
            string route = $"/v1/shops/{shopId}/webhooks.json";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Webhook>>(content);
        }

        /// <summary>
        /// Create a new webhook
        /// <para />
        /// <see href="https://developers.printify.com/#create-a-new-webhook"/>
        /// </summary>
        public async Task<Webhook> CreateWebhookAsync(int shopId, WebhookCreateRequest webhookCreateRequest)
        {
            string route = $"/v1/shops/{shopId}/webhooks.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(webhookCreateRequest));
            HttpResponseMessage resp = await PostAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Webhook>(responseContent);
        }

        /// <summary>
        /// Modify a webhook
        /// <para />
        /// <see href="https://developers.printify.com/#create-a-new-webhook"/>
        /// </summary>
        public async Task<Webhook> UpdateWebhookAsync(int shopId, string webhookId, WebhookUpdateRequest webhookUpdateRequest)
        {
            string route = $"/v1/shops/{shopId}/webhooks/{webhookId}.json";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(webhookUpdateRequest));
            HttpResponseMessage resp = await PutAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Webhook>(responseContent);
        }

        /// <summary>
        /// Delete a webhook
        /// <para />
        /// <see href="https://developers.printify.com/#delete-a-webhook"/>
        /// </summary>
        public async Task DeleteWebhookAsync(int shopId, string webhookId)
        {
            string route = $"/v1/shops/{shopId}/webhooks/{webhookId}.json";
            await DeleteAsync(route);
        }

        #endregion

    }
}
