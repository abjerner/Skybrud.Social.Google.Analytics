using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.WebProperties {
    
    /// <summary>
    /// Class representing a web property of a Google Analytics account.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/analytics/devguides/config/mgmt/v3/mgmtReference/management/webproperties</cref>
    /// </see>
    public class AnalyticsWebProperty : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the web property in the form <c>UA-XXXXX-YY</c>.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the ID of the Analytics account to which this web property belongs.
        /// </summary>
        public string AccountId { get; }

        /// <summary>
        /// Gets the internal ID of the web property.
        /// </summary>
        public string InternalWebPropertyId { get; }

        /// <summary>
        /// Gets the name of the web property.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the website URL of the web property.
        /// </summary>
        public string WebsiteUrl { get; }

        /// <summary>
        /// Gets the level of the web property.
        /// </summary>
        public string Level { get; }

        /// <summary>
        /// Gets the timestamp for when the web property was created.
        /// </summary>
        public DateTime Created { get; }

        /// <summary>
        /// Gets the timestamp for when the web property was last modified.
        /// </summary>
        public DateTime Updated { get; }

        #endregion

        #region Constructors

        private AnalyticsWebProperty(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            AccountId = obj.GetString("accountId");
            InternalWebPropertyId = obj.GetString("internalWebPropertyId");
            Name = obj.GetString("name");
            WebsiteUrl = obj.GetString("websiteUrl");
            Level = obj.GetString("level");
            Created = obj.GetDateTime("created");
            Updated = obj.GetDateTime("updated");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets a web property from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>The parsed instance of <see cref="AnalyticsWebProperty"/>, or <c>null</c> if <paramref name="obj"/> is <c>null</c>.</returns>
        public static AnalyticsWebProperty Parse(JObject obj) {
            return obj == null ? null : new AnalyticsWebProperty(obj);
        }

        #endregion

    }

}