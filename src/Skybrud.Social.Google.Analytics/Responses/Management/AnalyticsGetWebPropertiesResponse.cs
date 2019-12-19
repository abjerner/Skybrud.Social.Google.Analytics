using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Analytics.Models.WebProperties;

namespace Skybrud.Social.Google.Analytics.Responses.Management {

    /// <summary>
    /// Class representing the response of a request to get a list of web properties.
    /// </summary>
    public class AnalyticsGetWebPropertiesResponse : AnalyticsResponse<AnalyticsWebPropertiesCollection> {
        
        #region Constructors

        private AnalyticsGetWebPropertiesResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, AnalyticsWebPropertiesCollection.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="AnalyticsGetWebPropertiesResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="AnalyticsGetWebPropertiesResponse"/> representing the response.</returns>
        public static AnalyticsGetWebPropertiesResponse ParseResponse(IHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new AnalyticsGetWebPropertiesResponse(response);
        }

        #endregion

    }

}