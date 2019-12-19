using System;
using System.Collections.Generic;
using Skybrud.Social.Google.Analytics.Models.Fields;

namespace Skybrud.Social.Google.Analytics.Models.Metrics {

    /// <summary>
    /// Class representing a metric in the Google Analytics API.
    /// </summary>
    public class AnalyticsMetric : IAnalyticsField {

        #region Private fields

        private static readonly Dictionary<string, AnalyticsMetric> Metrics = new Dictionary<string, AnalyticsMetric>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets a dictionary containing all metrics. 
        /// </summary>
        public static Dictionary<string, AnalyticsMetric> All {
            get {
                AnalyticsMetrics.GetAll();
                AnalyticsRealtimeMetrics.GetAll();
                return Metrics;
            }
        }

        /// <summary>
        /// Gets the name of the metric.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the name of the group of the metric.
        /// </summary>
        public string GroupName { get; }

        /// <summary>
        /// Gets whether the metric is obsolete.
        /// </summary>
        public bool IsObsolete { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new metric from the specified <paramref name="name"/> and <paramref name="groupName"/>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="groupName">The name of group of the metric.</param>
        /// <param name="obsolete">Indicates whether the metric is obsolete.</param>
        private AnalyticsMetric(string name, string groupName, bool obsolete) {
            Name = name;
            GroupName = groupName;
            IsObsolete = obsolete;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the name of the metric (eg. <c>ga:visits</c>).
        /// </summary>
        public override string ToString() {
            return Name;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Registers a new metric with the specified <paramref name="name"/> and returns the created metric. If a metric
        /// with the specified name already exists, the existing metric will be returned instead.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        public static AnalyticsMetric Register(string name) {
            return Register(name, null, false);
        }

        /// <summary>
        /// Registers a new dmetricimension with the specified <paramref name="name"/> and returns the created metric. If a
        /// metric with the specified name already exists, the existing metric will be returned instead.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="groupName">The group name of the metric.</param>
        public static AnalyticsMetric Register(string name, string groupName) {
            return Register(name, groupName, false);
        }

        /// <summary>
        /// Registers a new metric with the specified <paramref name="name"/> and returns the created metric. If a metric
        /// with the specified name already exists, the existing metric will be returned instead.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="groupName">The group name of the metric.</param>
        /// <param name="obsolete">Whether the metric is obsolete.</param>
        public static AnalyticsMetric Register(string name, string groupName, bool obsolete) {
            if (All.TryGetValue(name, out var metric)) return metric;
            metric = new AnalyticsMetric(name, groupName, obsolete);
            All.Add(metric.Name, metric);
            return metric;
        }

        /// <summary>
        /// Gets a reference to the metric with the specified <paramref name="name"/>, or <c>null</c> if not found.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <returns>An instance of <see cref="AnalyticsMetric"/> if the metric is found, otherwise <c>null</c>.</returns>
        public static AnalyticsMetric Get(string name) {
            return All.TryGetValue(name, out var metric) ? metric : null;
        }

        /// <summary>
        /// Attempts to find metric with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="metric">The metric.</param>
        /// <returns><c>true</c> if the metric was found, otherwise <c>false</c>.</returns>
        public static bool TryGet(string name, out AnalyticsMetric metric) {
            return All.TryGetValue(name, out metric);
        }

        /// <summary>
        /// Gets whether a metric with the specified <paramref name="name"/> already exists.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <returns>Returns <c>true</c> if the metric exists, otherwise <c>false</c>.</returns>
        public static bool Exists(string name) {
            return All.ContainsKey(name);
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new metric from the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <returns>An instance of <see cref="AnalyticsMetric"/> representing the metric.</returns>
        public static implicit operator AnalyticsMetric(string name) {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return Register(name);
        }

        /// <summary>
        /// Gets a new collection containg the <paramref name="left"/> and <paramref name="right"/> metrics.
        /// </summary>
        /// <param name="left">The metric to the left of the operator.</param>
        /// <param name="right">The metric to the right of the operator.</param>
        /// <returns>An instance of <see cref="AnalyticsMetricCollection"/>.</returns>
        public static AnalyticsMetricCollection operator +(AnalyticsMetric left, AnalyticsMetric right) {
            return new AnalyticsMetricCollection(left, right);
        }

        #endregion

    }

}