using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Analytics.Http;
using Skybrud.Social.Google.Analytics.Options.Data;

namespace Skybrud.Social.Google.Analytics.Endpoints.Raw {
    
    /// <summary>
    /// Raw implementation of the data endpoint.
    /// </summary>
    public class AnalyticsDataRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Analytics client.
        /// </summary>
        public AnalyticsHttpClient Client { get; }

        #endregion

        #region Constructors

        internal AnalyticsDataRawEndpoint(AnalyticsHttpClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets historical data based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the response.</returns>
        public IHttpResponse GetData(AnalyticsGetDataOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Gets realtime data based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the response.</returns>
        public IHttpResponse GetRealtimeData(AnalyticsGetRealtimeDataOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }
        
        #endregion

    }

}