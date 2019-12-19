using System;
using Skybrud.Social.Google.Analytics.Endpoints.Raw;
using Skybrud.Social.Google.Analytics.Options.Data;
using Skybrud.Social.Google.Analytics.Responses.Data;

namespace Skybrud.Social.Google.Analytics.Endpoints {
    
    /// <summary>
    /// Implementation of the data endpoint.
    /// </summary>
    public class AnalyticsDataEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent Analytics service.
        /// </summary>
        public AnalyticsService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public AnalyticsDataRawEndpoint Raw => Service.Client.Data;

        #endregion

        #region Constructors

        internal AnalyticsDataEndpoint(AnalyticsService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets historical data based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="AnalyticsGetDataResponse"/> representing the response.</returns>
        public AnalyticsGetDataResponse GetData(AnalyticsGetDataOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return AnalyticsGetDataResponse.ParseResponse(Raw.GetData(options));
        }

        /// <summary>
        /// Gets realtime data based on the specified <paramref name="options"/>
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="AnalyticsGetRealtimeDataResponse"/> representing the response.</returns>
        public AnalyticsGetRealtimeDataResponse GetRealtimeData(AnalyticsGetRealtimeDataOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return AnalyticsGetRealtimeDataResponse.ParseResponse(Raw.GetRealtimeData(options));
        }
        
        #endregion

    }

}