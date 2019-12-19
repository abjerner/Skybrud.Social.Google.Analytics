using Skybrud.Social.Google.Analytics.Endpoints.Raw;
using Skybrud.Social.Google.Http;
using Skybrud.Social.Google.OAuth;

namespace Skybrud.Social.Google.Analytics.Http {

    public class AnalyticsHttpClient : GoogleApiHttpClientBase {

        #region Properties

        /// <summary>
        /// Gets a reference to raw <strong>Data</strong> endpoint.
        /// </summary>
        public AnalyticsDataRawEndpoint Data { get; }

        /// <summary>
        /// Gets a reference to raw <strong>Management</strong> endpoint.
        /// </summary>
        public AnalyticsManagementRawEndpoint Management { get; }

        #endregion

        #region Constructors

        public AnalyticsHttpClient(GoogleOAuthClient client) : base(client) {
            Data = new AnalyticsDataRawEndpoint(this);
            Management = new AnalyticsManagementRawEndpoint(this);
        }

        #endregion

    }

}