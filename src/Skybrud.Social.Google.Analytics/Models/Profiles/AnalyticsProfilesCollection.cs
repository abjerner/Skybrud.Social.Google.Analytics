using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Profiles {

    /// <summary>
    /// Class representing the response body of a request to get a list of profiles.
    /// </summary>
    public class AnalyticsProfilesCollection : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the <c>kind</c> of the object.
        /// </summary>
        public string Kind { get; }

        /// <summary>
        /// Gets the username of the authenticated user.
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// Gets the total amount of results.
        /// </summary>
        public int TotalResults { get; }

        /// <summary>
        /// Gets the start index of the current page.
        /// </summary>
        public int StartIndex { get; }

        /// <summary>
        /// Gets the amount of results per page.
        /// </summary>
        public int ItemsPerPage { get; }

        /// <summary>
        /// Gets a link for the previous page.
        /// </summary>
        public string PreviousLink { get; }

        /// <summary>
        /// Gets a link for the next page.
        /// </summary>
        public string NextLink { get; }

        /// <summary>
        /// Gets an array of web properties of the current page.
        /// </summary>
        public AnalyticsProfile[] Items { get; }

        #endregion

        #region Constructors

        private AnalyticsProfilesCollection(JObject obj) : base(obj) {
            Kind = obj.GetString("kind");
            Username = obj.GetString("username");
            TotalResults = obj.GetInt32("totalResults");
            StartIndex = obj.GetInt32("startIndex");
            ItemsPerPage = obj.GetInt32("itemsPerPage");
            PreviousLink = obj.GetString("previousLink");
            NextLink = obj.GetString("nextLink");
            Items = obj.GetArray("items", AnalyticsProfile.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="AnalyticsProfilesCollection"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        public static AnalyticsProfilesCollection Parse(JObject obj) {
            return obj == null ? null : new AnalyticsProfilesCollection(obj);
        }

        #endregion

    }

}