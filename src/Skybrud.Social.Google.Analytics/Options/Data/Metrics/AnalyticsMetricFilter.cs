using System;
using Skybrud.Social.Google.Analytics.Models.Fields;
using Skybrud.Social.Google.Analytics.Models.Metrics;

namespace Skybrud.Social.Google.Analytics.Options.Data.Metrics {

    public class AnalyticsMetricFilter : IAnalyticsFilter {

        #region Private fields

        private AnalyticsMetric _metric;
        private AnalyticsMetricOperator _operator;

        #endregion

        #region Properties

        public string Name => Metric.Name;

        public string OperatorValue => Operator.Value;

        public AnalyticsMetric Metric {
            get => _metric;
            set => _metric = value ?? throw new ArgumentNullException(nameof(value));
        }
        
        public AnalyticsMetricOperator Operator {
            get => _operator;
            set => _operator = value ?? throw new ArgumentNullException(nameof(value));
        }

        public object Value { get; set; }

        #endregion

        #region Constructor

        public AnalyticsMetricFilter(AnalyticsMetric metric, AnalyticsMetricOperator op, object value) {
            Metric = metric ?? throw new ArgumentNullException(nameof(metric));
            Operator = op ?? throw new ArgumentNullException(nameof(op));
            Value = value;
        }

        #endregion

    }

}