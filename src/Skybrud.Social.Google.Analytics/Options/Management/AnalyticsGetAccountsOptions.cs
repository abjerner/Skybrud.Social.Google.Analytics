using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Skybrud.Social.Google.Analytics.Options.Management {

    /// <summary>
    /// Class representing the options for getting accounts from the Analytics API.
    /// </summary>
    public class AnalyticsGetAccountsOptions : IHttpRequestOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the maximum amount of results returned. If <c>0</c>, the default maximum of the API will be used.
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
        public AnalyticsGetAccountsOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="maxResults"/>.
        /// </summary>
        /// <param name="maxResults">The maximum number of accounts to include in this response.</param>
        public AnalyticsGetAccountsOptions(int maxResults) {
            MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="maxResults"/> and <paramref name="startIndex"/>.
        /// </summary>
        /// <param name="maxResults">The maximum number of accounts to include in this response.</param>
        /// <param name="startIndex">The index of the first account to retrieve. The first account holds the index <c>1</c>.</param>
        public AnalyticsGetAccountsOptions(int maxResults, int startIndex) {
            MaxResults = maxResults;
            StartIndex = startIndex;
        }
        
        #endregion
        
        #region Member methods
        
        public IHttpRequest GetRequest() {

            IHttpQueryString query = new HttpQueryString();
            if (StartIndex > 0) query.Add("start-index", StartIndex);
            if (MaxResults > 0) query.Add("max-results", MaxResults);

            return HttpRequest.Get("/analytics/v3/management/accounts", query);

        }

        #endregion

    }

}