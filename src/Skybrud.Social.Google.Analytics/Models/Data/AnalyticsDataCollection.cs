using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Data {

    /// <summary>
    /// Class representing the response body of a request to get Analytics data.
    /// </summary>
    public class AnalyticsDataCollection : GoogleApiResource {

        #region Properties

        /// <summary>
        /// Gets the amount of results per page.
        /// </summary>
        public int ItemsPerPage { get; }

        /// <summary>
        /// Gets the total amount of results.
        /// </summary>
        public int TotalResults { get; }
        
        /// <summary>
        /// Gets a link for the current page.
        /// </summary>
        public string SelfLink { get; }

        /// <summary>
        /// Gets a link for the previous page.
        /// </summary>
        public string PreviousLink { get; }
        
        /// <summary>
        /// Gets a link for the next page.
        /// </summary>
        public string NextLink { get; }

        /// <summary>
        /// Gets a reference to an object with information about the requested profile.
        /// </summary>
        public AnalyticsProfileInfo ProfileInfo { get; }

        /// <summary>
        /// Gets an object describing the query.
        /// </summary>
        public AnalyticsDataQuery Query { get; }

        /// <summary>
        /// Gets an array of the column headers.
        /// </summary>
        public AnalyticsDataColumnHeader[] ColumnHeaders { get; }

        /// <summary>
        /// Gets an array of rows for the current page.
        /// </summary>
        public AnalyticsDataRow[] Rows { get; }

        #endregion

        #region Constructors

        private AnalyticsDataCollection(JObject obj) : base(obj) {

            // Get the column headers
            AnalyticsDataColumnHeader[] columns = obj.GetArray("columnHeaders", AnalyticsDataColumnHeader.Parse);

            Query = obj.GetObject("query", AnalyticsDataQuery.Parse);
            ItemsPerPage = obj.GetInt32("itemsPerPage");
            TotalResults = obj.GetInt32("totalResults");
            SelfLink = obj.GetString("selfLink");
            PreviousLink = obj.GetString("nextLink");
            NextLink = obj.GetString("previousLink");
            ProfileInfo = obj.GetObject("profileInfo", AnalyticsProfileInfo.Parse);
            //ContainsSampledData = obj.GetBoolean("containsSampledData");
            ColumnHeaders = columns;
            // TotalForAllResults = obj.GetBoolean("totalForAllResults");
            Rows = AnalyticsDataRow.Parse(columns, obj.GetArray("rows"));

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="AnalyticsDataCollection"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="AnalyticsDataCollection"/>.</returns>
        public static AnalyticsDataCollection Parse(JObject obj) {
            return obj == null ? null : new AnalyticsDataCollection(obj);
        }

        #endregion

    }

}