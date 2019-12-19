using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Data {

    /// <summary>
    /// Class representing the query of a Analytics realtime data response.
    /// </summary>
    public class AnalyticsRealtimeDataQuery : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the profile.
        /// </summary>
        public string Ids { get; }

        /// <summary>
        /// Gets the start index of the current page of results.
        /// </summary>
        public int StartIndex { get; }

        /// <summary>
        /// Gets the maximum results per page.
        /// </summary>
        public int MaxResults { get; }

        /// <summary>
        /// Gets an array of the dimensions specified for the current query.
        /// </summary>
        public string[] Dimensions { get; }

        /// <summary>
        /// Gets an array of the metrics specified for the current query.
        /// </summary>
        public string[] Metrics { get; }

        #endregion
        
        #region Constructors

        private AnalyticsRealtimeDataQuery(JObject obj) : base(obj) {
            Ids = obj.GetString("ids");
            StartIndex = obj.GetInt32("start-index");
            MaxResults = obj.GetInt32("max-results");
            Dimensions = (obj.GetString("dimensions") ?? string.Empty).Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Metrics = obj.GetStringArray("metrics");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="AnalyticsDataQuery"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="AnalyticsDataQuery"/>.</returns>
        public static AnalyticsRealtimeDataQuery Parse(JObject obj) {
            return obj == null ? null : new AnalyticsRealtimeDataQuery(obj);
        }

        #endregion

    }

}