using Skybrud.Social.Google.Attributes;
using Skybrud.Social.Google.Scopes;

namespace Skybrud.Social.Google.Analytics.Scopes {

    /// <summary>
    /// Static class containing references to known scopes of the Analytics API.
    /// </summary>
    [GoogleScopes("Analytics")]
    public static class AnalyticsScopes {

        /// <summary>
        /// Read-only access to the Analytics API.
        /// </summary>
        public static readonly AnalyticsScope Readonly = new AnalyticsScope(
            "https://www.googleapis.com/auth/analytics.readonly",
            "Readonly",
            "Read-only access to the Analytics API."
        );

        /// <summary>
        /// Write access to the Analytics API.
        /// </summary>
        public static readonly AnalyticsScope Write = new AnalyticsScope(
            "https://www.googleapis.com/auth/analytics",
            "Write",
            "Write access to the Analytics API."
        );

        /// <summary>
        /// Edit Google Analytics management entities.
        /// </summary>
        public static readonly AnalyticsScope Edit = new AnalyticsScope(
            "https://www.googleapis.com/auth/analytics.edit",
            "Edit",
            "Edit Google Analytics management entities."
        );

        /// <summary>
        /// View and manage user permissions for Analytics accounts.
        /// </summary>
        public static readonly AnalyticsScope ManageUsers = new AnalyticsScope(
            "https://www.googleapis.com/auth/analytics.manage.users",
            "Manage users",
            "View and manage user permissions for Analytics accounts."
        );

        /// <summary>
        /// View Google Analytics user permissions.
        /// </summary>
        public static readonly AnalyticsScope ManageUsersReadonly = new AnalyticsScope(
            "https://www.googleapis.com/auth/analytics.manage.users.readonly",
            "Manage users (readonly)",
            "View Google Analytics user permissions."
        );

        /// <summary>
        /// Gets an array of all Analytics scopes.
        /// </summary>
        public static readonly GoogleScope[] All = { Readonly, Write, Edit, ManageUsers, ManageUsersReadonly };

    }

}