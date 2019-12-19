using Skybrud.Social.Google.Analytics.Endpoints;
using Skybrud.Social.Google.Analytics.Http;

namespace Skybrud.Social.Google.Analytics {

    public class AnalyticsService : GoogleApiServiceBase {

        #region Properties

        /// <summary>
        /// Gets a reference to the Analytics HTTP client.
        /// </summary>
        public AnalyticsHttpClient Client => Service.Client.Analytics();

        /// <summary>
        /// Gets a reference to the <strong>Data</strong> endpoint.
        /// </summary>
        public AnalyticsDataEndpoint Data { get; }

        /// <summary>
        /// Gets a reference to the <strong>Management</strong> endpoint.
        /// </summary>
        public AnalyticsManagementEndpoint Management { get; }

        #endregion

        #region Constructors

        public AnalyticsService(GoogleService service) : base(service) {
            Data = new AnalyticsDataEndpoint(this);
            Management = new AnalyticsManagementEndpoint(this);
        }

        #endregion

    }

}