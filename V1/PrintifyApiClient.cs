using PrintifyApi.V1.Models.Catalog.Blueprints;
using PrintifyApi.V1.Models.Catalog.Blueprints.ShippingInformation;
using PrintifyApi.V1.Models.Shops.Orders;
using PrintifyApi.V1.Models.Shops.Orders.Create;
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
        public async Task<List<Order>> GetOrdersAsync(int shopId, int limit = 0, int page = 0, string status = "", string sku = "")
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
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(content);
        }

        /// <summary>
        /// Get order details by ID
        /// <para />
        /// <see href="https://developers.printify.com/#get-order-details-by-id"/>
        /// </summary>
        public async Task<Order> GetOrderAsync(int shopId, int orderId)
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
            StringContent requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(order));
            HttpResponseMessage resp = await PostAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PostOrderResponse>(responseContent);
        }

        /// <summary>
        /// Send an existing order to production
        /// <para />
        /// <see href="https://developers.printify.com/#send-an-existing-order-to-production"/>
        /// </summary>
        public async Task<InitiatedOrder> PostOrderToProductionAsync(int shopId, int orderId)
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
            StringContent requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(order));
            HttpResponseMessage resp = await PostAsync(route, requestContent);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ShippingCostResponse>(responseContent);
        }

        /// <summary>
        /// Cancel an order
        /// <para />
        /// <see href="https://developers.printify.com/#cancel-an-order"/>
        /// </summary>
        public async Task<InitiatedOrder> CancelOrder(int shopId, int orderId)
        {
            string route = $"/v1/shops/{shopId}/orders/{orderId}/cancel.json";
            HttpResponseMessage resp = await PostAsync(route, null);
            string responseContent = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<InitiatedOrder>(responseContent);
        }

        #endregion

        /*
        

        
        GET /v1/shops.json
        DELETE /v1/shops/{shop_id}/connection.json

        GET /v1/shops/{shop_id}/products.json
        GET /v1/shops/{shop_id}/products/{product_id}.json
        POST /v1/shops/{shop_id}/products.json
        PUT /v1/shops/{shop_id}/products/{product_id}.json
        DELETE /v1/shops/{shop_id}/products/{product_id}.json
        POST /v1/shops/{shop_id}/products/{product_id}/publish.json
        POST /v1/shops/{shop_id}/products/{product_id}/publishing_succeeded.json
        POST /v1/shops/{shop_id}/products/{product_id}/publishing_failed.json
        POST /v1/shops/{shop_id}/products/{product_id}/unpublish.json

        GET /v1/uploads.json
        GET /v1/uploads/{image_id}.json
        POST /v1/uploads/images.json
        POST /v1/uploads/{image_id}/archive.json

        GET /v1/shops/{shop_id}/webhooks.json
        POST /v1/shops/{shop_id}/webhooks.json
        PUT /v1/shops/{shop_id}/webhooks/{webhook_id}.json
        DELETE /v1/shops/{shop_id}/webhooks/{webhook_id}.json
        */

    }
}
