using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Analytics.Http;
using Skybrud.Social.Google.Analytics.Options.Management;

namespace Skybrud.Social.Google.Analytics.Endpoints.Raw {
    
    /// <summary>
    /// Raw implementation of the management endpoint.
    /// </summary>
    public class AnalyticsManagementRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Analytics client.
        /// </summary>
        public AnalyticsHttpClient Client { get; }

        #endregion

        #region Constructors

        internal AnalyticsManagementRawEndpoint(AnalyticsHttpClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of Analytics accounts of the authenticated user.
        /// </summary>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the response.</returns>
        public IHttpResponse GetAccounts() {
            return GetAccounts(new AnalyticsGetAccountsOptions());
        }

        /// <summary>
        /// Gets a list of Analytics accounts of the authenticated user.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the response.</returns>
        public IHttpResponse GetAccounts(AnalyticsGetAccountsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Gets a list of web properties based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the response.</returns>
        public IHttpResponse GetWebProperties(AnalyticsGetWebPropertiesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Gets a list of profiles based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the response.</returns>
        public IHttpResponse GetProfiles(AnalyticsGetProfilesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }
        
        #endregion

    }

}