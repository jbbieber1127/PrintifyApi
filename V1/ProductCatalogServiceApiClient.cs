using PrintifyApi.V1.Models.Catalog.Blueprints;
using PrintifyApi.V1.Models.CatalogServiceApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.RateLimiting;
using System.Threading.Tasks;

namespace PrintifyApi.V1
{
    /// <summary>
    /// Provides an interface for the API requests that Printify's UI makes to retrieve more information about items in the catalog.
    /// <para />
    /// This interface does not require authentication, but I've still included a rate limiting implementation. Let's be respectful of Printify's services.
    /// </summary>
    public class ProductCatalogServiceApiClient : HttpClient
    {

        /// <summary>
        /// A constructor that adds rate limiting
        /// </summary>
        public ProductCatalogServiceApiClient(string baseUrl, int maxRequestsRate, TimeSpan ratePeriod) : base(new ClientSideRateLimitedHandler(new TokenBucketRateLimiter(new TokenBucketRateLimiterOptions()
        {
            TokenLimit = maxRequestsRate,
            ReplenishmentPeriod = ratePeriod,
            TokensPerPeriod = (int)(maxRequestsRate * 0.75),

            QueueLimit = int.MaxValue,
            QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
            AutoReplenishment = true
        })))
        {
            BaseAddress = new Uri(baseUrl);
        }

        public ProductCatalogServiceApiClient(string baseUrl)
        {
            BaseAddress = new Uri(baseUrl);
        }

        public async Task<BlueprintDetails> GetBlueprintDetailsAsync(int blueprintId)
        {

            string route = $"/v1/blueprints/{blueprintId}";
            HttpResponseMessage resp = await GetAsync(route);
            string content = await resp.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BlueprintDetails>(content);
        }

        //public async Task<Object> SearchCatalogAsync(int page = 1, int limit = 24, Filters filters, tags)
        //{

        //}
    }
}
