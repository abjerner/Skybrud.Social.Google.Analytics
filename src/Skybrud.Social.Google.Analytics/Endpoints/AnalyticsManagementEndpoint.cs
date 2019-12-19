using System;
using Skybrud.Social.Google.Analytics.Endpoints.Raw;
using Skybrud.Social.Google.Analytics.Options.Management;
using Skybrud.Social.Google.Analytics.Responses.Management;

namespace Skybrud.Social.Google.Analytics.Endpoints {
    
    /// <summary>
    /// Implementation of the management endpoint.
    /// </summary>
    public class AnalyticsManagementEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent Analytics service.
        /// </summary>
        public AnalyticsService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public AnalyticsManagementRawEndpoint Raw => Service.Client.Management;

        #endregion

        #region Constructors

        internal AnalyticsManagementEndpoint(AnalyticsService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of Analytics accounts of the authenticated user.
        /// </summary>
        public AnalyticsGetAccountsResponse GetAccounts() {
            return AnalyticsGetAccountsResponse.ParseResponse(Raw.GetAccounts());
        }

        /// <summary>
        /// Gets a list of Analytics accounts of the authenticated user matching the specified <paramref name="options"/>.
        /// </summary>
        public AnalyticsGetAccountsResponse GetAccounts(AnalyticsGetAccountsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return AnalyticsGetAccountsResponse.ParseResponse(Raw.GetAccounts(options));
        }

        /// <summary>
        /// Gets a list of web properties using default options.
        /// </summary>
        public AnalyticsGetWebPropertiesResponse GetWebProperties() {
            return GetWebProperties(new AnalyticsGetWebPropertiesOptions());
        }

        /// <summary>
        /// Gets a list of web properties based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public AnalyticsGetWebPropertiesResponse GetWebProperties(AnalyticsGetWebPropertiesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return AnalyticsGetWebPropertiesResponse.ParseResponse(Raw.GetWebProperties(options));
        }

        /// <summary>
        /// Gets a list of profiles using default options.
        /// </summary>
        public AnalyticsGetProfilesResponse GetProfiles() {
            return GetProfiles(new AnalyticsGetProfilesOptions());
        }

        /// <summary>
        /// Gets a list of profiles based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public AnalyticsGetProfilesResponse GetProfiles(AnalyticsGetProfilesOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return AnalyticsGetProfilesResponse.ParseResponse(Raw.GetProfiles(options));
        }
        
        #endregion

    }

}