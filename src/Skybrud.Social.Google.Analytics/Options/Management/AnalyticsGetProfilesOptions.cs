using System;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Skybrud.Social.Google.Analytics.Options.Management {

    /// <summary>
    /// Class representing the options for getting profiles from the Analytics API.
    /// </summary>
    public class AnalyticsGetProfilesOptions : IHttpRequestOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the parent account. If set to <c>~all</c>, profiles of all accounts
        /// (that the authenticated user has access to) will be returned.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the parent web property. If set to <c>~all</c>, profiles of all web properties
        /// (that the authenticated user has access to) will be returned.
        /// </summary>
        public string WebPropertyId { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of results returned. If <c>0</c>, the default maximum of the API will
        /// be used.
        /// </summary>
        public int MaxResults { get; set; }

        /// <summary>
        /// Gets or sets the start index.
        /// </summary>
        public int StartIndex { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public AnalyticsGetProfilesOptions() {
            AccountId = "~all";
            WebPropertyId = "~all";
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="maxResults"/>.
        /// </summary>
        /// <param name="maxResults">The maximum number of profiles to include in this response.</param>
        public AnalyticsGetProfilesOptions(int maxResults) : this() {
            MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="maxResults"/> and <paramref name="startIndex"/>.
        /// </summary>
        /// <param name="maxResults">The maximum number of profiles to include in this response.</param>
        /// <param name="startIndex">The index of the first profile to retrieve. The first profile holds the index <c>1</c>.</param>
        public AnalyticsGetProfilesOptions(int maxResults, int startIndex) : this() {
            MaxResults = maxResults;
            StartIndex = startIndex;
        }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        /// <param name="accountId">The ID of the parent account.</param>
        /// <param name="webPropertyId">The ID of the parent web property.</param>
        public AnalyticsGetProfilesOptions(string accountId, string webPropertyId) : this() {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId));
            AccountId = accountId;
            WebPropertyId = webPropertyId;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="maxResults"/>.
        /// </summary>
        /// <param name="accountId">The ID of the parent account.</param>
        /// <param name="webPropertyId">The ID of the parent web property.</param>
        /// <param name="maxResults">The maximum number of profiles to include in this response.</param>
        public AnalyticsGetProfilesOptions(string accountId, string webPropertyId, int maxResults) : this() {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId));
            AccountId = accountId;
            WebPropertyId = webPropertyId;
            MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="maxResults"/> and <paramref name="startIndex"/>.
        /// </summary>
        /// <param name="accountId">The ID of the parent account.</param>
        /// <param name="webPropertyId">The ID of the parent web property.</param>
        /// <param name="maxResults">The maximum number of profiles to include in this response.</param>
        /// <param name="startIndex">The index of the first profile to retrieve. The first profile holds the index <code>1</code>.</param>
        public AnalyticsGetProfilesOptions(string accountId, string webPropertyId, int maxResults, int startIndex) : this() {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId));
            AccountId = accountId;
            WebPropertyId = webPropertyId;
            MaxResults = maxResults;
            StartIndex = startIndex;
        }
        
        #endregion

        #region Member methods
        
        public IHttpRequest GetRequest() {

            if (string.IsNullOrWhiteSpace(AccountId)) throw new PropertyNotSetException(nameof(AccountId));
            if (string.IsNullOrWhiteSpace(WebPropertyId)) throw new PropertyNotSetException(nameof(WebPropertyId));

            IHttpQueryString query = new HttpQueryString();
            if (StartIndex > 0) query.Add("start-index", StartIndex);
            if (MaxResults > 0) query.Add("max-results", MaxResults);

            return HttpRequest.Get($"/analytics/v3/management/accounts/{AccountId}/webproperties/{WebPropertyId}/profiles", query);

        }

        #endregion

    }

}