using PrintifyApi.V1.Models.Images;
using System.Threading.RateLimiting;

namespace PrintifyApi.V1
{
    /// <summary>
    /// Provides an interface for the API requests that Printify's makes to retrieve images.
    /// <para />
    /// This interface does not require authentication, but I've still included a rate limiting implementation. Let's be respectful of Printify's services.
    /// </summary>
    public class PrintifyImagesClient : HttpClient
    {
        /// <summary>
        /// A constructor that adds rate limiting
        /// </summary>
        public PrintifyImagesClient(string baseUrl, int maxRequestsRate, TimeSpan ratePeriod) : base(new ClientSideRateLimitedHandler(new TokenBucketRateLimiter(new TokenBucketRateLimiterOptions()
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

        public PrintifyImagesClient(string baseUrl)
        {
            BaseAddress = new Uri(baseUrl);
        }

        public async Task<HttpContent> GetPreviewImage(PreviewRequest previewRequest)
        {
            string route = $"/preview";
            StringContent requestContent = new(Newtonsoft.Json.JsonConvert.SerializeObject(previewRequest));
            HttpResponseMessage resp = await PostAsync(route, requestContent);
            resp.EnsureSuccessStatusCode();
            return resp.Content;
        }
    }
}
