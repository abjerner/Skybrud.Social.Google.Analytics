using System;
using Skybrud.Social.Google.Analytics.Models.Dimensions;
using Skybrud.Social.Google.Analytics.Models.Fields;

namespace Skybrud.Social.Google.Analytics.Options.Data.Dimensions {

    public class AnalyticsDimensionFilter : IAnalyticsFilter {

        #region Private fields

        private AnalyticsDimension _dimension;
        private AnalyticsDimensionOperator _operator;

        #endregion

        #region Properties

        public string Name => Dimension.Name;

        public string OperatorValue => Operator.Value;

        public AnalyticsDimension Dimension {
            get => _dimension;
            set => _dimension = value ?? throw new ArgumentNullException(nameof(value));
        }

        public AnalyticsDimensionOperator Operator {
            get => _operator;
            set => _operator = value ?? throw new ArgumentNullException(nameof(value));
        }

        public object Value { get; set; }

        #endregion

        #region Constructor

        public AnalyticsDimensionFilter(AnalyticsDimension dimension, AnalyticsDimensionOperator op, object value) {
            Dimension = dimension ?? throw new ArgumentNullException(nameof(dimension));
            Operator = op ?? throw new ArgumentNullException(nameof(op));
            Value = value;

        }

        #endregion
    
    }

}