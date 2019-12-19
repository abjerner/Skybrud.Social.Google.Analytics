using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Analytics.Models.Accounts;

namespace Skybrud.Social.Google.Analytics.Responses.Management {

    /// <summary>
    /// Class representing the response of a request to get a list of Analytics accounts.
    /// </summary>
    public class AnalyticsGetAccountsResponse : AnalyticsResponse<AnalyticsAccountsCollection> {
        
        #region Constructors

        private AnalyticsGetAccountsResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, AnalyticsAccountsCollection.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="AnalyticsGetAccountsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="AnalyticsGetAccountsResponse"/> representing the response.</returns>
        public static AnalyticsGetAccountsResponse ParseResponse(IHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new AnalyticsGetAccountsResponse(response);
        }

        #endregion

    }

}