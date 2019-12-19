using Skybrud.Social.Google.Scopes;

namespace Skybrud.Social.Google.Analytics.Scopes {
    
    /// <summary>
    /// Class representing a scope in the Google Analytics API.
    /// </summary>
    public class AnalyticsScope : GoogleScope {

        #region Constructors

        /// <summary>
        /// Initializes a new scope with the specified <paramref name="alias"/>, <paramref name="name"/> and <paramref name="description"/>.
        /// </summary>
        /// <param name="alias">The alias of the scope.</param>
        /// <param name="name">The name of the scope.</param>
        /// <param name="description">The description of the scope.</param>
        public AnalyticsScope(string alias, string name, string description) : base(alias, name, description) { }

        #endregion

    }

}