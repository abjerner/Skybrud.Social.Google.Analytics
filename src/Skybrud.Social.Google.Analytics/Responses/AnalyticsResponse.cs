using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Responses;

namespace Skybrud.Social.Google.Analytics.Responses {

    /// <summary>
    /// Class representing a response from the Analytics API.
    /// </summary>
    public class AnalyticsResponse<T> : GoogleApiResponse<T> {

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The underlying raw response the instance should be based on.</param>
        protected AnalyticsResponse(IHttpResponse response) : base(response) { }

        #endregion

    }

}