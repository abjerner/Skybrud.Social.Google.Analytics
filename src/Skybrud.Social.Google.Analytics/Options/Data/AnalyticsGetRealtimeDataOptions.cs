using System;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.Google.Analytics.Models.Dimensions;
using Skybrud.Social.Google.Analytics.Models.Metrics;
using Skybrud.Social.Google.Analytics.Models.Profiles;
using Skybrud.Social.Google.Analytics.Options.Data.Dimensions;
using Skybrud.Social.Google.Analytics.Options.Data.Filters;
using Skybrud.Social.Google.Analytics.Options.Data.Metrics;
using Skybrud.Social.Google.Analytics.Options.Data.Sorting;

namespace Skybrud.Social.Google.Analytics.Options.Data {

    /// <summary>
    /// Class representing the options for getting realtime data from the Analytics API.
    /// </summary>
    public class AnalyticsGetRealtimeDataOptions : IHttpRequestOptions {

        #region Private fields

        private AnalyticsFilterOptions _filters = new AnalyticsFilterOptions();
        private AnalyticsDataSortOptions _sorting = new AnalyticsDataSortOptions();

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the profile.
        /// </summary>
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the metrics.
        /// </summary>
        public AnalyticsMetricCollection Metrics { get; set; }

        /// <summary>
        /// Gets or sets the dimensions.
        /// </summary>
        public AnalyticsDimensionCollection Dimensions { get; set; }

        /// <summary>
        /// Gets or sets the filter options.
        /// </summary>
        public AnalyticsFilterOptions Filters {
            get => _filters;
            set => _filters = value ?? new AnalyticsFilterOptions();
        }

        /// <summary>
        /// A list of metrics and dimensions indicating the sorting order and sorting direction for the returned data.
        /// </summary>
        public AnalyticsDataSortOptions Sorting {
            get => _sorting;
            set => _sorting = value ?? new AnalyticsDataSortOptions();
        }

        /// <summary>
        /// Gets or sets the maximum amount of results returned (default: 1000).
        /// </summary>
        public int MaxResults { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public AnalyticsGetRealtimeDataOptions() {
            MaxResults = 1000;
        }

        /// <summary>
        /// Initializes a new instance with default options and based on the specified <paramref name="profile"/>.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public AnalyticsGetRealtimeDataOptions(AnalyticsProfile profile) : this() {
            if (profile == null) throw new ArgumentNullException(nameof(profile));
            ProfileId = profile.Id;
        }

        /// <summary>
        /// Initializes a new instance with default options and based on the profile with the specified <paramref name="profileId"/>.
        /// </summary>
        /// <param name="profileId">The ID of the profile.</param>
        public AnalyticsGetRealtimeDataOptions(string profileId) : this() {
            ProfileId = profileId;
        }

        #endregion

        #region Methods
        public IHttpRequest GetRequest() {

            IHttpQueryString query = new HttpQueryString();
            if (!string.IsNullOrWhiteSpace(ProfileId)) query.Add("ids", (ProfileId.StartsWith("ga:") ? ProfileId : "ga:" + ProfileId));
            query.Add("metrics", Metrics == null ? "" : Metrics.ToString());
            if (Dimensions != null && Dimensions.Count > 0) query.Add("dimensions", Dimensions == null ? "" : Dimensions.ToString());
            if (Filters.HasBlocks) query.Add("filters", Filters.ToString());
            if (Sorting.HasFields) query.Add("sort", Sorting.ToString());
            if (MaxResults > 0 && MaxResults != 1000) query.Add("max-results", MaxResults);

            return HttpRequest.Get("/analytics/v3/data/realtime", query);

        }

        /// <summary>
        /// Adds the specified metric.
        /// </summary>
        /// <param name="metric">The metric to add.</param>
        public AnalyticsGetRealtimeDataOptions AddMetric(AnalyticsMetric metric) {
            if (Metrics == null) Metrics = new AnalyticsMetricCollection();
            Metrics.Add(metric);
            return this;
        }

        /// <summary>
        /// Adds the specified sequence of metrics.
        /// </summary>
        /// <param name="metrics">The metrics to add.</param>
        public AnalyticsGetRealtimeDataOptions AddMetrics(params AnalyticsMetric[] metrics) {
            if (Metrics == null) Metrics = new AnalyticsMetricCollection();
            Metrics.AddRange(metrics);
            return this;
        }

        /// <summary>
        /// Adds the specified dimension.
        /// </summary>
        /// <param name="dimension">The dimension to add.</param>
        public AnalyticsGetRealtimeDataOptions AddDimension(AnalyticsDimension dimension) {
            if (Dimensions == null) Dimensions = new AnalyticsDimensionCollection();
            Dimensions.Add(dimension);
            return this;
        }

        /// <summary>
        /// Adds the specified sequence of dimensions.
        /// </summary>
        /// <param name="dimensions">The dimensions to add.</param>
        public AnalyticsGetRealtimeDataOptions AddDimensions(params AnalyticsDimension[] dimensions) {
            if (Dimensions == null) Dimensions = new AnalyticsDimensionCollection();
            Dimensions.AddRange(dimensions);
            return this;
        }

        /// <summary>
        /// Adds the specified metric filter.
        /// </summary>
        /// <param name="filter">The filter to add.</param>
        public AnalyticsGetRealtimeDataOptions AddMetricFilter(AnalyticsMetricFilter filter) {
            _filters.Add(filter);
            return this;
        }

        /// <summary>
        /// Adds a metric filter with the specified information.
        /// </summary>
        /// <param name="metric">The metric.</param>
        /// <param name="op">The operator.</param>
        /// <param name="value">The value.</param>
        public AnalyticsGetRealtimeDataOptions AddMetricFilter(AnalyticsMetric metric, AnalyticsMetricOperator op, string value) {
            _filters.Add(new AnalyticsMetricFilter(metric, op, value));
            return this;
        }

        /// <summary>
        /// Adds the specified dimension filter.
        /// </summary>
        /// <param name="filter">The filter to add.</param>
        public AnalyticsGetRealtimeDataOptions AddDimensionFilter(AnalyticsDimensionFilter filter) {
            _filters.Add(filter);
            return this;
        }

        /// <summary>
        /// Adds a dimension filter with the specified information.
        /// </summary>
        /// <param name="dimension">The dimension.</param>
        /// <param name="op">The operator.</param>
        /// <param name="value">The value.</param>
        public AnalyticsGetRealtimeDataOptions AddDimensionFilter(AnalyticsDimension dimension, AnalyticsDimensionOperator op, string value) {
            _filters.Add(new AnalyticsDimensionFilter(dimension, op, value));
            return this;
        }

        #endregion

    }

}