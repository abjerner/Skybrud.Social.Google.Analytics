using System;
using Skybrud.Social.Google.Analytics.Models.Fields;

namespace Skybrud.Social.Google.Analytics.Options.Data.Dimensions {

    public class AnalyticsDimensionOperator : IAnalyticsFieldOperator {

        #region Static properties

        public static readonly AnalyticsDimensionOperator ExactMatch = new AnalyticsDimensionOperator("==");
        public static readonly AnalyticsDimensionOperator DoesNotMatch = new AnalyticsDimensionOperator("!=");
        public static readonly AnalyticsDimensionOperator ContainsSubstring = new AnalyticsDimensionOperator("=@");
        public static readonly AnalyticsDimensionOperator DoesNotContainSubstring = new AnalyticsDimensionOperator("!@");
        public static readonly AnalyticsDimensionOperator RegexMatch = new AnalyticsDimensionOperator("=~");
        public static readonly AnalyticsDimensionOperator RegexNotMatch = new AnalyticsDimensionOperator("!~");

        public static AnalyticsDimensionOperator[] Values => new [] {
            ExactMatch,
            DoesNotMatch,
            ContainsSubstring,
            DoesNotContainSubstring,
            RegexMatch,
            RegexNotMatch
        };

        #endregion

        #region Properties

        public string Value { get; }

        #endregion

        #region Constructor

        private AnalyticsDimensionOperator(string value) {
            Value = value;
        }

        #endregion

        #region Static methods

        public static AnalyticsDimensionOperator Parse(string str) {
            if (TryParse(str, out var op)) return op;
            throw new Exception("Invalid operator '" + str + "'");
        }

        public static bool TryParse(string str, out AnalyticsDimensionOperator op) {
            foreach (AnalyticsDimensionOperator temp in Values) {
                if (temp.Value != str) continue;
                op = temp;
                return true;
            }
            op = null;
            return false;
        }

        #endregion

        #region Operator overloading

        public static implicit operator AnalyticsDimensionOperator(string value) {
            return new AnalyticsDimensionOperator(value);
        }

        #endregion

    }

}