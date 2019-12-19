using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Profiles {
    
    /// <summary>
    /// Class representing a web profile in a Google Analytics context.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/analytics/devguides/config/mgmt/v3/mgmtReference/management/profiles#resource</cref>
    /// </see>
    public class AnalyticsProfile : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the profile.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the ID of the parent Analytics account.
        /// </summary>
        public string AccountId { get; }

        /// <summary>
        /// Gets the eeb property ID of the form <c>UA-XXXXX-YY</c> to which this profile belongs.
        /// </summary>
        public string WebPropertyId { get; }

        /// <summary>
        /// Gets the internal ID for the web property to which this profile belongs.
        /// </summary>
        public string InternalWebPropertyId { get; }

        /// <summary>
        /// Gets the name of the 
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the currency type associated with this profile, defaults to <c>USD</c>. 
        /// </summary>
        public string Currency { get; }

        /// <summary>
        /// Gets the time zone for which this profile has been configured. 
        /// </summary>
        public string Timezone { get; }

        /// <summary>
        /// Gets the website URL of the profile.
        /// </summary>
        public string WebsiteUrl { get; }

        /// <summary>
        /// Gets the type of the profile. Can be either <c>WEB</c> or <c>APP</c>.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the timestamp for when the profile was created.
        /// </summary>
        public DateTime Created { get; }

        /// <summary>
        /// Gets the timestamp for when the profile was last modified.
        /// </summary>
        public DateTime Updated { get; }

        #endregion

        #region Constructors

        private AnalyticsProfile(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            AccountId = obj.GetString("accountId");
            WebPropertyId = obj.GetString("webPropertyId");
            InternalWebPropertyId = obj.GetString("internalWebPropertyId");
            Name = obj.GetString("name");
            Currency = obj.GetString("currency");
            Timezone = obj.GetString("timezone");
            WebsiteUrl = obj.GetString("websiteUrl");
            Type = obj.GetString("type");
            Created = obj.GetDateTime("created");
            Updated = obj.GetDateTime("updated");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets a profile from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>The parsed instance of <see cref="AnalyticsProfile"/>, or <c>null</c> if <paramref name="obj"/> is <c>null</c>.</returns>
        public static AnalyticsProfile Parse(JObject obj) {
            return obj == null ? null : new AnalyticsProfile(obj);
        }

        #endregion

    }

}