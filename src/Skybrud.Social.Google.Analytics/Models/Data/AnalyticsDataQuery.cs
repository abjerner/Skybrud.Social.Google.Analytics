using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Data {

    /// <summary>
    /// Class representing the query of a Analytics data response.
    /// </summary>
    public class AnalyticsDataQuery : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the profile.
        /// </summary>
        public string Ids { get; }

        /// <summary>
        /// Gets the start date of the query.
        /// </summary>
        public string StartDate { get; }

        /// <summary>
        /// Gets the end date of the query.
        /// </summary>
        public string EndDate { get; }

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

        private AnalyticsDataQuery(JObject obj) : base(obj) {
            Ids = obj.GetString("ids");
            StartDate = obj.GetString("start-date");
            EndDate = obj.GetString("end-date");
            StartIndex = obj.GetInt32("start-index");
            MaxResults = obj.GetInt32("max-results");
            Dimensions = (obj.GetString("dimensions") ?? "").Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            Metrics = obj.GetStringArray("metrics");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="AnalyticsDataQuery"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="AnalyticsDataQuery"/>.</returns>
        public static AnalyticsDataQuery Parse(JObject obj) {
            return obj == null ? null : new AnalyticsDataQuery(obj);
        }

        #endregion

    }

}