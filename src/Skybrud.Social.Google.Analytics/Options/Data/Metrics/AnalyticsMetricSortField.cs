using System;
using Skybrud.Social.Google.Analytics.Models.Data;
using Skybrud.Social.Google.Analytics.Models.Fields;
using Skybrud.Social.Google.Analytics.Models.Metrics;

namespace Skybrud.Social.Google.Analytics.Options.Data.Metrics {
    
    public class AnalyticsMetricSortField : IAnalyticsSortField {

        #region Properties

        public AnalyticsDataSortOrder Order { get; set; }

        public IAnalyticsField Field => Metric;

        public AnalyticsMetric Metric { get; set; }

        #endregion

        #region Constructors

        public AnalyticsMetricSortField() { }

        public AnalyticsMetricSortField(AnalyticsMetric metric, AnalyticsDataSortOrder order) {
            Metric = metric ?? throw new ArgumentNullException(nameof(metric));
            Order = order;
        }

        #endregion

    }

}