using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Models;

namespace Skybrud.Social.Google.Analytics.Models.Data {

    /// <summary>
    /// Class representing the column of a Analytics data response.
    /// </summary>
    public class AnalyticsDataColumnHeader : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// Gets the name of the column.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the type of the column.
        /// </summary>
        public AnalyticsColumnType ColumnType { get; internal set; }

        /// <summary>
        /// Gets the data type of the column.
        /// </summary>
        public AnalyticsDataType DataType { get; internal set; }

        #endregion

        #region Constructors

        private AnalyticsDataColumnHeader(JObject obj) : base(obj) {
            Name = obj.GetString("name");
            ColumnType = obj.GetEnum<AnalyticsColumnType>("columnType");
            DataType = obj.GetEnum<AnalyticsDataType>("dataType");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="AnalyticsDataColumnHeader"/> from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="AnalyticsDataColumnHeader"/>.</returns>
        public static AnalyticsDataColumnHeader Parse(JObject obj) {
            return obj == null ? null: new AnalyticsDataColumnHeader(obj);
        }

        #endregion
        
    }

}