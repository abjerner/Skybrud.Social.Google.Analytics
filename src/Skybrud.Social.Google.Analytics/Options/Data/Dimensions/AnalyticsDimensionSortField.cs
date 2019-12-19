using System;
using Skybrud.Social.Google.Analytics.Models.Data;
using Skybrud.Social.Google.Analytics.Models.Dimensions;
using Skybrud.Social.Google.Analytics.Models.Fields;

namespace Skybrud.Social.Google.Analytics.Options.Data.Dimensions {
    
    public class AnalyticsDimensionSortField : IAnalyticsSortField {

        #region Properties

        public AnalyticsDataSortOrder Order { get; set; }

        public IAnalyticsField Field => Dimension;

        public AnalyticsDimension Dimension { get; set; }

        #endregion

        #region Constructors

        public AnalyticsDimensionSortField() {
            // Default constructor
        }

        public AnalyticsDimensionSortField(AnalyticsDimension dimension, AnalyticsDataSortOrder order) {
            Dimension = dimension ?? throw new ArgumentNullException(nameof(dimension));
            Order = order;
        }

        #endregion

    }

}