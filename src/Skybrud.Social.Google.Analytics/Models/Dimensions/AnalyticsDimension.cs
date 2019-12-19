using System;
using System.Collections.Generic;
using Skybrud.Social.Google.Analytics.Models.Fields;

namespace Skybrud.Social.Google.Analytics.Models.Dimensions {

    /// <summary>
    /// Class representing a dimension in the Google Analytics API.
    /// </summary>
    public class AnalyticsDimension : IAnalyticsField {

        #region Private fields

        private static readonly Dictionary<string, AnalyticsDimension> Dimensions = new Dictionary<string, AnalyticsDimension>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets a dictionary containing all dimensions. 
        /// </summary>
        public static Dictionary<string, AnalyticsDimension> All {
            get {
                AnalyticsDimensions.GetAll();
                AnalyticsRealtimeDimensions.GetAll();
                return Dimensions;
            }
        }

        /// <summary>
        /// Gets the name of the dimension.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the name of the group of the dimension.
        /// </summary>
        public string GroupName { get; }

        /// <summary>
        /// Gets whether the dimension is obsolete/deprecated.
        /// </summary>
        public bool IsObsolete { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new dimension from the specified <paramref name="name"/> and <paramref name="groupName"/>.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <param name="groupName">The name of group of the dimension.</param>
        /// <param name="obsolete">Indicates whether the dimension is obsolete.</param>
        public AnalyticsDimension(string name, string groupName, bool obsolete) {
            Name = name;
            GroupName = groupName;
            IsObsolete = obsolete;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the name of the dimension (eg. <c>ga:country</c>).
        /// </summary>
        public override string ToString() {
            return Name;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Registers a new dimension with the specified <paramref name="name"/> and returns the created dimension. If a
        /// dimension with the specified name already exists, the existing dimension will be returned instead.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        public static AnalyticsDimension Register(string name) {
            return Register(name, null, false);
        }

        /// <summary>
        /// Registers a new dimension with the specified <paramref name="name"/> and returns the created dimension. If a
        /// dimension with the specified name already exists, the existing dimension will be returned instead.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <param name="groupName">The group name of the dimension.</param>
        public static AnalyticsDimension Register(string name, string groupName) {
            return Register(name, groupName, false);
        }

        /// <summary>
        /// Registers a new dimension with the specified <paramref name="name"/> and returns the created dimension. If a
        /// dimension with the specified name already exists, the existing dimension will be returned instead.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <param name="groupName">The group name of the dimension.</param>
        /// <param name="obsolete">Whether the dimension is obsolete.</param>
        public static AnalyticsDimension Register(string name, string groupName, bool obsolete) {
            if (All.TryGetValue(name, out var dimension)) return dimension;
            dimension = new AnalyticsDimension(name, groupName, obsolete);
            All.Add(dimension.Name, dimension);
            return dimension;
        }

        /// <summary>
        /// Gets a reference to the dimension with the specified <paramref name="name"/>, or <c>null</c> if not found.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <returns>An instance of <see cref="AnalyticsDimension"/> if the dimension is found, otherwise <c>null</c>.</returns>
        public static AnalyticsDimension Get(string name) {
            return All.TryGetValue(name, out var dimension) ? dimension : null;
        }

        /// <summary>
        /// Attempts to find dimension with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <param name="dimension">The dimension.</param>
        /// <returns><c>true</c> if the dimension was found, otherwise <c>false</c>.</returns>
        public static bool TryGet(string name, out AnalyticsDimension dimension) {
            return All.TryGetValue(name, out dimension);
        }

        /// <summary>
        /// Gets whether a dimension with the specified <paramref name="name"/> already exists.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <returns><c>true</c> if the dimension exists, otherwise <c>false</c>.</returns>
        public static bool Exists(string name) {
            return All.ContainsKey(name);
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new dimension from the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the dimension.</param>
        /// <returns>An instance of <see cref="AnalyticsDimension"/> representing the dimension.</returns>
        public static implicit operator AnalyticsDimension(string name) {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return Register(name);
        }

        /// <summary>
        /// Gets a new collection containg the <paramref name="left"/> and <paramref name="right"/> dimensions.
        /// </summary>
        /// <param name="left">The dimension to the left of the operator.</param>
        /// <param name="right">The dimension to the right of the operator.</param>
        /// <returns>An instance of <see cref="AnalyticsDimension"/>.</returns>
        public static AnalyticsDimensionCollection operator +(AnalyticsDimension left, AnalyticsDimension right) {
            return new AnalyticsDimensionCollection(left, right);
        }

        #endregion

    }

}