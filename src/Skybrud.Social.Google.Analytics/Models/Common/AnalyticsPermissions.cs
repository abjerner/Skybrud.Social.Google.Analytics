using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Common {
    
    /// <summary>
    /// Class describing the permissions to an Analytics account.
    /// </summary>
    public class AnalyticsPermissions : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets an array of permissions to the parent account.
        /// </summary>
        public string[] Effective { get; }

        #endregion

        #region Constructors

        private AnalyticsPermissions(JObject obj) : base(obj) {
            Effective = obj.GetStringArray("effective") ?? new string[0];
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="AnalyticsPermissions"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        public static AnalyticsPermissions Parse(JObject obj) {
            return obj == null ? null : new AnalyticsPermissions(obj);
        }

        #endregion

    }

}