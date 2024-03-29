using System;
using Skybrud.Social.Google.Analytics.Models.Fields;

namespace Skybrud.Social.Google.Analytics.Options.Data.Metrics {
    
    public class AnalyticsMetricOperator : IAnalyticsFieldOperator {

        #region Static properties

        public new static readonly AnalyticsMetricOperator Equals = new AnalyticsMetricOperator("==");
        public static readonly AnalyticsMetricOperator DoesNotEqual = new AnalyticsMetricOperator("!=");
        public static readonly AnalyticsMetricOperator GreaterThan = new AnalyticsMetricOperator(">");
        public static readonly AnalyticsMetricOperator LessThan = new AnalyticsMetricOperator("<");
        public static readonly AnalyticsMetricOperator GreaterThanOrEqualTo = new AnalyticsMetricOperator(">=");
        public static readonly AnalyticsMetricOperator LessThanOrEqualTo = new AnalyticsMetricOperator("<=");

        public static AnalyticsMetricOperator[] Values => new[] {
            Equals,
            DoesNotEqual,
            GreaterThan,
            LessThan,
            GreaterThanOrEqualTo,
            LessThanOrEqualTo
        };

        #endregion

        #region Properties

        public string Value { get; set; }

        #endregion

        #region Constructor

        private AnalyticsMetricOperator(string value) {
            Value = value;
        }

        #endregion

        #region Static methods

        public static AnalyticsMetricOperator Parse(string str) {
            if (TryParse(str, out var op)) return op;
            throw new Exception("Invalid operator '" + str + "'");
        }

        public static bool TryParse(string str, out AnalyticsMetricOperator op) {
            foreach (AnalyticsMetricOperator temp in Values) {
                if (temp.Value != str) continue;
                op = temp;
                return true;
            }
            op = null;
            return false;
        }

        #endregion

        #region Operator overloading

        public static implicit operator AnalyticsMetricOperator(string value) {
            return new AnalyticsMetricOperator(value);
        }

        #endregion

    }

}