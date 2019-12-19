using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Accounts {

    /// <summary>
    /// Class representing the response body of a request to get a list of Analytics accounts.
    /// </summary>
    public class AnalyticsAccountsCollection : GoogleApiObject {

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
        /// Gets an array of accounts of the current page.
        /// </summary>
        public AnalyticsAccount[] Items { get; }

        #endregion

        #region Constructors

        private AnalyticsAccountsCollection(JObject obj) : base(obj) {
            Kind = obj.GetString("kind");
            Username = obj.GetString("username");
            TotalResults = obj.GetInt32("totalResults");
            StartIndex = obj.GetInt32("startIndex");
            ItemsPerPage = obj.GetInt32("itemsPerPage");
            Items = obj.GetArray("items", AnalyticsAccount.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="AnalyticsAccountsCollection"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        public static AnalyticsAccountsCollection Parse(JObject obj) {
            return obj == null ? null : new AnalyticsAccountsCollection(obj);
        }

        #endregion

    }

}