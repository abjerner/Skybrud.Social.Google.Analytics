using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Data {

    /// <summary>
    /// Class representing an object wih information about a profile.
    /// </summary>
    public class AnalyticsProfileInfo : GoogleApiObject  {

        #region Properties

        /// <summary>
        /// Gets the ID of the profile.
        /// </summary>
        public string ProfileId { get; }

        /// <summary>
        /// Gets the ID of the parent account.
        /// </summary>
        public string AccountId { get; }
        
        /// <summary>
        /// Gets the ID of the parent web property.
        /// </summary>
        public string WebPropertyId { get; }
        
        /// <summary>
        /// Gets the internal ID of the parent web property.
        /// </summary>
        public string InternalWebPropertyId { get; }
        
        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        public string ProfileName { get; }

        /// <summary>
        /// Gets the ID of the table.
        /// </summary>
        public string TableId { get; }

        #endregion

        #region Constructors

        private AnalyticsProfileInfo(JObject obj) : base(obj) {
            ProfileId = obj.GetString("profileId");
            AccountId = obj.GetString("accountId");
            WebPropertyId = obj.GetString("webPropertyId");
            InternalWebPropertyId = obj.GetString("internalWebPropertyId");
            ProfileName = obj.GetString("profileName");
            TableId = obj.GetString("tableId");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="AnalyticsProfileInfo"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        public static AnalyticsProfileInfo Parse(JObject obj) {
            return obj == null ? null : new AnalyticsProfileInfo(obj);
        }

        #endregion

    }

}