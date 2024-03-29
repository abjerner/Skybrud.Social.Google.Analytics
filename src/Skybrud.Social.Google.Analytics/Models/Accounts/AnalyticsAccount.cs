﻿using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Analytics.Models.Common;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Accounts {
    
    /// <summary>
    /// Class representing a Google Analytics account. This is not the same as a Google Account,
    /// since a Google Account can have multiple Analytics accounts.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/analytics/devguides/config/mgmt/v3/mgmtReference/management/accounts</cref>
    /// </see>
    public class AnalyticsAccount : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the account.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the name of the account.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets a reference to an object describing the permissions to the account.
        /// </summary>
        public AnalyticsPermissions Permissions { get; }

        /// <summary>
        /// Gets the creation date of the account.
        /// </summary>
        public DateTime Created { get; }

        /// <summary>
        /// Gets the update date of the account.
        /// </summary>
        public DateTime Updated { get; }

        #endregion

        #region Constructors

        private AnalyticsAccount(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            Permissions = obj.GetObject("permissions", AnalyticsPermissions.Parse);
            Created = obj.GetDateTime("created");
            Updated = obj.GetDateTime("updated");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an account from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>The parsed instance of <see cref="AnalyticsAccount"/>, or <c>null</c> if <paramref name="obj"/> is <c>null</c>.</returns>
        public static AnalyticsAccount Parse(JObject obj) {
            return obj == null ? null : new AnalyticsAccount(obj);
        }

        #endregion

    }

}