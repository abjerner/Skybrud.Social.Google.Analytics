﻿using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Analytics.Models.Data;

namespace Skybrud.Social.Google.Analytics.Responses.Data {

    /// <summary>
    /// Class representing the response of a request to get Analytics data.
    /// </summary>
    public class AnalyticsGetDataResponse : AnalyticsResponse<AnalyticsDataCollection> {
        
        #region Constructors

        private AnalyticsGetDataResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, AnalyticsDataCollection.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="AnalyticsGetDataResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="AnalyticsGetDataResponse"/> representing the response.</returns>
        public static AnalyticsGetDataResponse ParseResponse(IHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new AnalyticsGetDataResponse(response);
        }

        #endregion

    }

}