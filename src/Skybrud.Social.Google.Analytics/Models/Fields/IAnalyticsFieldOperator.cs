namespace Skybrud.Social.Google.Analytics.Models.Fields {
    
    /// <summary>
    /// Interface a field operator in the Analytics API.
    /// </summary>
    public interface IAnalyticsFieldOperator {
    
        /// <summary>
        /// Gets the value of the operator.
        /// </summary>
        string Value { get; }
    
    }

}