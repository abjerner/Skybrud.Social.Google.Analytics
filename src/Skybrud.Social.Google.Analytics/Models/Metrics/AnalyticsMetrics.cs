﻿// This class is auto-generated based on metrics from the Google Analytics API. If you have suggestions for any
// changes, please create a new issue at https://github.com/abjerner/Skybrud.Social/issues/new

using System;

namespace Skybrud.Social.Google.Analytics.Models.Metrics {

    /// <summary>
    /// Static class with constants for the various metrics of the Google Analytics API
    /// </summary>
    public static class AnalyticsMetrics {

        // ReSharper disable InconsistentNaming

        #region User

        /// <summary>
        /// Gets the total number of users for the requested time period (id: <code>ga:users</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_users</cref>
        /// </see>
        public static readonly AnalyticsMetric Users = AnalyticsMetric.Register("ga:users", "User");

        /// <summary>
        /// Gets the total number of users for the requested time period (id: <code>ga:visitors</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_visitors</cref>
        /// </see>
        [Obsolete("Use ga:users instead.")]
        public static readonly AnalyticsMetric Visitors = AnalyticsMetric.Register("ga:visitors", "User", true);

        /// <summary>
        /// Gets the number of users whose session was marked as a first-time session (id: <code>ga:newUsers)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_newusers</cref>
        /// </see>
        public static readonly AnalyticsMetric NewUsers = AnalyticsMetric.Register("ga:newUsers", "User");

        /// <summary>
        /// Gets the number of users whose session was marked as a first-time session (id: <code>ga:newVisits)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_newvisits</cref>
        /// </see>
        [Obsolete("Use ga:newUsers instead.")]
        public static readonly AnalyticsMetric NewVisits = AnalyticsMetric.Register("ga:newVisits", "User", true);

        /// <summary>
        /// Gets the percentage of sessions by people who had never visited your property before (id: <code>ga:percentNewSessions)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_percentnewsessions</cref>
        /// </see>
        public static readonly AnalyticsMetric PercentNewSessions = AnalyticsMetric.Register("ga:percentNewSessions", "User");

        /// <summary>
        /// Gets the percentage of sessions by people who had never visited your property before (id: <code>ga:percentNewVisits)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_percentnewvisits</cref>
        /// </see>
        [Obsolete("Use ga:percentNewSessions instead.")]
        public static readonly AnalyticsMetric PercentNewVisits = AnalyticsMetric.Register("ga:percentNewVisits", "User", true);

        /// <summary>
        /// Gets the total number of 1-day active users for each day in the requested time period. At least one of <code>ga:nthDay</code>, <code>ga:date</code>, or <code>ga:day</code> must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 1 day period ending on the given date (id: <code>ga:1dayUsers)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_1dayusers</cref>
        /// </see>
        public static readonly AnalyticsMetric Day1Users = AnalyticsMetric.Register("ga:1dayUsers", "User");

        /// <summary>
        /// Gets the total number of 7-day active users for each day in the requested time period. At least one of <code>ga:nthDay</code>, <code>ga:date</code>, or <code>ga:day</code> must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 7 day period ending on the given date (id: <code>ga:7dayUsers)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_7dayusers</cref>
        /// </see>
        public static readonly AnalyticsMetric Day7Users = AnalyticsMetric.Register("ga:7dayUsers", "User");

        /// <summary>
        /// Gets the total number of 14-day active users for each day in the requested time period. At least one of <code>ga:nthDay</code>, <code>ga:date</code>, or <code>ga:day</code> must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 14 day period ending on the given date (id: <code>ga:14dayUsers)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_14dayusers</cref>
        /// </see>
        public static readonly AnalyticsMetric Day14Users = AnalyticsMetric.Register("ga:14dayUsers", "User");

        /// <summary>
        /// Gets the total number of 30-day active users for each day in the requested time period. At least one of <code>ga:nthDay</code>, <code>ga:date</code>, or <code>ga:day</code> must be specified as a dimension in order to query this metric. For the given date the returned value will be the total unique users for the 30 day period ending on the given date (id: <code>ga:30dayUsers)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_30dayusers</cref>
        /// </see>
        public static readonly AnalyticsMetric Day30Users = AnalyticsMetric.Register("ga:30dayUsers", "User");

        /// <summary>
        /// Gets the total number of sessions divided by the total number of users (id: <code>ga:sessionsPerUser)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user&amp;jump=ga_sessionsperuser</cref>
        /// </see>
        public static readonly AnalyticsMetric SessionsPerUser = AnalyticsMetric.Register("ga:sessionsPerUser", "User");

        #endregion

        #region Session

        /// <summary>
        /// Gets the total number of sessions (id: <code>ga:sessions</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_sessions</cref>
        /// </see>
        public static readonly AnalyticsMetric Sessions = AnalyticsMetric.Register("ga:sessions", "Session");

        /// <summary>
        /// Gets the total number of sessions (id: <code>ga:visits</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_visits</cref>
        /// </see>
        [Obsolete("Use ga:sessions instead.")]
        public static readonly AnalyticsMetric Visits = AnalyticsMetric.Register("ga:visits", "Session", true);

        /// <summary>
        /// Gets the total number of single page (or single engagement hit) sessions for your property (id: <code>ga:bounces</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_bounces</cref>
        /// </see>
        public static readonly AnalyticsMetric Bounces = AnalyticsMetric.Register("ga:bounces", "Session");

        /// <summary>
        /// This dimension is deprecated and will be removed soon. Please use <code>ga:bounceRate</code> instead (id: <code>ga:entranceBounceRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_entrancebouncerate</cref>
        /// </see>
        [Obsolete("Use ga:bounceRate instead.")]
        public static readonly AnalyticsMetric EntranceBounceRate = AnalyticsMetric.Register("ga:entranceBounceRate", "Session", true);

        /// <summary>
        /// Gets the percentage of single-page session (i.e., session in which the person left your property from the first page) (id: <code>ga:bounceRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_bouncerate</cref>
        /// </see>
        public static readonly AnalyticsMetric BounceRate = AnalyticsMetric.Register("ga:bounceRate", "Session");

        /// <summary>
        /// Gets the percentage of single-page session (i.e., session in which the person left your property from the first page) (id: <code>ga:visitBounceRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_visitbouncerate</cref>
        /// </see>
        [Obsolete("Use ga:bounceRate instead.")]
        public static readonly AnalyticsMetric VisitBounceRate = AnalyticsMetric.Register("ga:visitBounceRate", "Session", true);

        /// <summary>
        /// Gets the total duration of user sessions represented in total seconds (id: <code>ga:sessionDuration)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_sessionduration</cref>
        /// </see>
        public static readonly AnalyticsMetric SessionDuration = AnalyticsMetric.Register("ga:sessionDuration", "Session");

        /// <summary>
        /// Gets the total duration of user sessions represented in total seconds (id: <code>ga:timeOnSite)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_timeonsite</cref>
        /// </see>
        [Obsolete("Use ga:sessionDuration instead.")]
        public static readonly AnalyticsMetric TimeOnSite = AnalyticsMetric.Register("ga:timeOnSite", "Session", true);

        /// <summary>
        /// Gets the average duration of user sessions represented in total seconds (id: <code>ga:avgSessionDuration)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_avgsessionduration</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgSessionDuration = AnalyticsMetric.Register("ga:avgSessionDuration", "Session");

        /// <summary>
        /// Gets the average duration of user sessions represented in total seconds (id: <code>ga:avgTimeOnSite)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_avgtimeonsite</cref>
        /// </see>
        [Obsolete("Use ga:avgSessionDuration instead.")]
        public static readonly AnalyticsMetric AvgTimeOnSite = AnalyticsMetric.Register("ga:avgTimeOnSite", "Session", true);

        /// <summary>
        /// Gets the total number of hits sent to Google Analytics, for the view (profile). This metric sums all hit types, including pageview, custom event, ecommerce, and other types. Note that this number is based on the view (profile), not the property, and therefore is not the same as the property's hit volume (id: <code>ga:hits</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=session&amp;jump=ga_hits</cref>
        /// </see>
        public static readonly AnalyticsMetric Hits = AnalyticsMetric.Register("ga:hits", "Session");

        #endregion

        #region Traffic Sources

        /// <summary>
        /// Gets the number of organic searches that happened within a session. This metric is search engine agnostic (id: <code>ga:organicSearches)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=traffic_sources&amp;jump=ga_organicsearches</cref>
        /// </see>
        public static readonly AnalyticsMetric OrganicSearches = AnalyticsMetric.Register("ga:organicSearches", "Traffic Sources");

        #endregion

        #region Adwords

        /// <summary>
        /// Gets the total number of campaign impressions (id: <code>ga:impressions</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_impressions</cref>
        /// </see>
        public static readonly AnalyticsMetric Impressions = AnalyticsMetric.Register("ga:impressions", "Adwords");

        /// <summary>
        /// Gets the total number of times users have clicked on an ad to reach your property (id: <code>ga:adClicks)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adclicks</cref>
        /// </see>
        public static readonly AnalyticsMetric AdClicks = AnalyticsMetric.Register("ga:adClicks", "Adwords");

        /// <summary>
        /// Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account (id: <code>ga:adCost)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_adcost</cref>
        /// </see>
        public static readonly AnalyticsMetric AdCost = AnalyticsMetric.Register("ga:adCost", "Adwords");

        /// <summary>
        /// Cost per thousand impressions (id: <code>ga:CPM)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_cpm</cref>
        /// </see>
        public static readonly AnalyticsMetric CPM = AnalyticsMetric.Register("ga:CPM", "Adwords");

        /// <summary>
        /// Cost to advertiser per click (id: <code>ga:CPC)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_cpc</cref>
        /// </see>
        public static readonly AnalyticsMetric CPC = AnalyticsMetric.Register("ga:CPC", "Adwords");

        /// <summary>
        /// Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared) (id: <code>ga:CTR)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_ctr</cref>
        /// </see>
        public static readonly AnalyticsMetric CTR = AnalyticsMetric.Register("ga:CTR", "Adwords");

        /// <summary>
        /// Gets the cost per transaction for your property (id: <code>ga:costPerTransaction)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_costpertransaction</cref>
        /// </see>
        public static readonly AnalyticsMetric CostPerTransaction = AnalyticsMetric.Register("ga:costPerTransaction", "Adwords");

        /// <summary>
        /// Gets the cost per goal conversion for your property (id: <code>ga:costPerGoalConversion)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_costpergoalconversion</cref>
        /// </see>
        public static readonly AnalyticsMetric CostPerGoalConversion = AnalyticsMetric.Register("ga:costPerGoalConversion", "Adwords");

        /// <summary>
        /// Gets the cost per conversion (including ecommerce and goal conversions) for your property (id: <code>ga:costPerConversion)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_costperconversion</cref>
        /// </see>
        public static readonly AnalyticsMetric CostPerConversion = AnalyticsMetric.Register("ga:costPerConversion", "Adwords");

        /// <summary>
        /// RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads (id: <code>ga:RPC)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_rpc</cref>
        /// </see>
        public static readonly AnalyticsMetric RPC = AnalyticsMetric.Register("ga:RPC", "Adwords");

        /// <summary>
        /// This metric is deprecated and will be removed soon. Please use <code>ga:ROAS</code> instead (id: <code>ga:ROI)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_roi</cref>
        /// </see>
        [Obsolete]
        public static readonly AnalyticsMetric ROI = AnalyticsMetric.Register("ga:ROI", "Adwords", true);

        /// <summary>
        /// This metric is deprecated and will be removed soon. Please use <code>ga:ROAS</code> instead (id: <code>ga:margin</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_margin</cref>
        /// </see>
        [Obsolete]
        public static readonly AnalyticsMetric Margin = AnalyticsMetric.Register("ga:margin", "Adwords", true);

        /// <summary>
        /// Return On Ad Spend (ROAS) is the total transaction revenue and goal value divided by derived advertising cost (id: <code>ga:ROAS)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adwords&amp;jump=ga_roas</cref>
        /// </see>
        public static readonly AnalyticsMetric ROAS = AnalyticsMetric.Register("ga:ROAS", "Adwords");

        #endregion

        #region Goal Conversions

        /// <summary>
        /// Gets the total number of starts for the requested goal number (id: <code>ga:goalXXStarts)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxstarts</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalXXStarts = AnalyticsMetric.Register("ga:goalXXStarts", "Goal Conversions");

        /// <summary>
        /// Gets the total number of starts for all goals defined for your profile (id: <code>ga:goalStartsAll)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalstartsall</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalStartsAll = AnalyticsMetric.Register("ga:goalStartsAll", "Goal Conversions");

        /// <summary>
        /// Gets the total number of completions for the requested goal number (id: <code>ga:goalXXCompletions)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxcompletions</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalXXCompletions = AnalyticsMetric.Register("ga:goalXXCompletions", "Goal Conversions");

        /// <summary>
        /// Gets the total number of completions for all goals defined for your profile (id: <code>ga:goalCompletionsAll)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalcompletionsall</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalCompletionsAll = AnalyticsMetric.Register("ga:goalCompletionsAll", "Goal Conversions");

        /// <summary>
        /// Gets the total numeric value for the requested goal number (id: <code>ga:goalXXValue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxvalue</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalXXValue = AnalyticsMetric.Register("ga:goalXXValue", "Goal Conversions");

        /// <summary>
        /// Gets the total numeric value for all goals defined for your profile (id: <code>ga:goalValueAll)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalvalueall</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalValueAll = AnalyticsMetric.Register("ga:goalValueAll", "Goal Conversions");

        /// <summary>
        /// Gets the average goal value of a session (id: <code>ga:goalValuePerSession)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalvaluepersession</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalValuePerSession = AnalyticsMetric.Register("ga:goalValuePerSession", "Goal Conversions");

        /// <summary>
        /// Gets the average goal value of a session (id: <code>ga:goalValuePerVisit)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalvaluepervisit</cref>
        /// </see>
        [Obsolete("Use ga:goalValuePerSession instead.")]
        public static readonly AnalyticsMetric GoalValuePerVisit = AnalyticsMetric.Register("ga:goalValuePerVisit", "Goal Conversions", true);

        /// <summary>
        /// Gets the percentage of sessions which resulted in a conversion to the requested goal number (id: <code>ga:goalXXConversionRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxconversionrate</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalXXConversionRate = AnalyticsMetric.Register("ga:goalXXConversionRate", "Goal Conversions");

        /// <summary>
        /// Gets the percentage of sessions which resulted in a conversion to at least one of your goals (id: <code>ga:goalConversionRateAll)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalconversionrateall</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalConversionRateAll = AnalyticsMetric.Register("ga:goalConversionRateAll", "Goal Conversions");

        /// <summary>
        /// Gets the number of times users started conversion activity on the requested goal number without actually completing it (id: <code>ga:goalXXAbandons)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxabandons</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalXXAbandons = AnalyticsMetric.Register("ga:goalXXAbandons", "Goal Conversions");

        /// <summary>
        /// Gets the overall number of times users started goals without actually completing them (id: <code>ga:goalAbandonsAll)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalabandonsall</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalAbandonsAll = AnalyticsMetric.Register("ga:goalAbandonsAll", "Goal Conversions");

        /// <summary>
        /// Gets the rate at which the requested goal number was abandoned (id: <code>ga:goalXXAbandonRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalxxabandonrate</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalXXAbandonRate = AnalyticsMetric.Register("ga:goalXXAbandonRate", "Goal Conversions");

        /// <summary>
        /// Gets the rate at which goals were abandoned (id: <code>ga:goalAbandonRateAll)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=goal_conversions&amp;jump=ga_goalabandonrateall</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalAbandonRateAll = AnalyticsMetric.Register("ga:goalAbandonRateAll", "Goal Conversions");

        #endregion

        #region Social Activities

        /// <summary>
        /// Gets the total number of activities where a content URL was shared / mentioned on a social data hub partner network (id: <code>ga:socialActivities)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_activities&amp;jump=ga_socialactivities</cref>
        /// </see>
        public static readonly AnalyticsMetric SocialActivities = AnalyticsMetric.Register("ga:socialActivities", "Social Activities");

        #endregion

        #region Page Tracking

        /// <summary>
        /// Gets the average value of this page or set of pages. Page Value is (<code>ga:transactionRevenue</code> + <code>ga:goalValueAll</code>) / <code>ga:uniquePageviews</code> (for the page or set of pages) (id: <code>ga:pageValue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pagevalue</cref>
        /// </see>
        public static readonly AnalyticsMetric PageValue = AnalyticsMetric.Register("ga:pageValue", "Page Tracking");

        /// <summary>
        /// Gets the number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath (id: <code>ga:entrances</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_entrances</cref>
        /// </see>
        public static readonly AnalyticsMetric Entrances = AnalyticsMetric.Register("ga:entrances", "Page Tracking");

        /// <summary>
        /// Gets the percentage of pageviews in which this page was the entrance (id: <code>ga:entranceRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_entrancerate</cref>
        /// </see>
        public static readonly AnalyticsMetric EntranceRate = AnalyticsMetric.Register("ga:entranceRate", "Page Tracking");

        /// <summary>
        /// Gets the total number of pageviews for your property (id: <code>ga:pageviews</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pageviews</cref>
        /// </see>
        public static readonly AnalyticsMetric Pageviews = AnalyticsMetric.Register("ga:pageviews", "Page Tracking");

        /// <summary>
        /// Gets the average number of pages viewed during a session, including repeated views of a single page (id: <code>ga:pageviewsPerSession)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pageviewspersession</cref>
        /// </see>
        public static readonly AnalyticsMetric PageviewsPerSession = AnalyticsMetric.Register("ga:pageviewsPerSession", "Page Tracking");

        /// <summary>
        /// Gets the average number of pages viewed during a session, including repeated views of a single page (id: <code>ga:pageviewsPerVisit)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_pageviewspervisit</cref>
        /// </see>
        [Obsolete("Use ga:pageviewsPerSession instead.")]
        public static readonly AnalyticsMetric PageviewsPerVisit = AnalyticsMetric.Register("ga:pageviewsPerVisit", "Page Tracking", true);

        /// <summary>
        /// Gets the number of unique page views. Page views within different sessions count as separate unique page views. This takes into account both the pagePath and pageTitle to determine uniqueness (id: <code>ga:uniquePageviews)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_uniquepageviews</cref>
        /// </see>
        public static readonly AnalyticsMetric UniquePageviews = AnalyticsMetric.Register("ga:uniquePageviews", "Page Tracking");

        /// <summary>
        /// Gets how long a user spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property (id: <code>ga:timeOnPage)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_timeonpage</cref>
        /// </see>
        public static readonly AnalyticsMetric TimeOnPage = AnalyticsMetric.Register("ga:timeOnPage", "Page Tracking");

        /// <summary>
        /// Gets the average amount of time users spent viewing this page or a set of pages (id: <code>ga:avgTimeOnPage)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_avgtimeonpage</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgTimeOnPage = AnalyticsMetric.Register("ga:avgTimeOnPage", "Page Tracking");

        /// <summary>
        /// Gets the number of exits from your property (id: <code>ga:exits</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_exits</cref>
        /// </see>
        public static readonly AnalyticsMetric Exits = AnalyticsMetric.Register("ga:exits", "Page Tracking");

        /// <summary>
        /// Gets the percentage of exits from your property that occurred out of the total page views (id: <code>ga:exitRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=page_tracking&amp;jump=ga_exitrate</cref>
        /// </see>
        public static readonly AnalyticsMetric ExitRate = AnalyticsMetric.Register("ga:exitRate", "Page Tracking");

        #endregion

        #region Content Grouping

        /// <summary>
        /// Gets the number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness (id: <code>ga:contentGroupUniqueViewsXX)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=content_grouping&amp;jump=ga_contentgroupuniqueviewsxx</cref>
        /// </see>
        public static readonly AnalyticsMetric ContentGroupUniqueViewsXX = AnalyticsMetric.Register("ga:contentGroupUniqueViewsXX", "Content Grouping");

        #endregion

        #region Internal Search

        /// <summary>
        /// Gets the number of times a search result page was viewed after performing a search (id: <code>ga:searchResultViews)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchresultviews</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchResultViews = AnalyticsMetric.Register("ga:searchResultViews", "Internal Search");

        /// <summary>
        /// Gets the total number of unique keywords from internal searches within a session. For example if "shoes" was searched for 3 times in a session, it will be only counted once (id: <code>ga:searchUniques)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchuniques</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchUniques = AnalyticsMetric.Register("ga:searchUniques", "Internal Search");

        /// <summary>
        /// Gets the average number of times people viewed a search results page after performing a search (id: <code>ga:avgSearchResultViews)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_avgsearchresultviews</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgSearchResultViews = AnalyticsMetric.Register("ga:avgSearchResultViews", "Internal Search");

        /// <summary>
        /// Gets the total number of sessions that included an internal search (id: <code>ga:searchSessions)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchsessions</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchSessions = AnalyticsMetric.Register("ga:searchSessions", "Internal Search");

        /// <summary>
        /// Gets the total number of sessions that included an internal search (id: <code>ga:searchVisits)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchvisits</cref>
        /// </see>
        [Obsolete("Use ga:searchSessions instead.")]
        public static readonly AnalyticsMetric SearchVisits = AnalyticsMetric.Register("ga:searchVisits", "Internal Search", true);

        /// <summary>
        /// Gets the percentage of sessions with search (id: <code>ga:percentSessionsWithSearch)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_percentsessionswithsearch</cref>
        /// </see>
        public static readonly AnalyticsMetric PercentSessionsWithSearch = AnalyticsMetric.Register("ga:percentSessionsWithSearch", "Internal Search");

        /// <summary>
        /// Gets the percentage of sessions with search (id: <code>ga:percentVisitsWithSearch)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_percentvisitswithsearch</cref>
        /// </see>
        [Obsolete("Use ga:percentSessionsWithSearch instead.")]
        public static readonly AnalyticsMetric PercentVisitsWithSearch = AnalyticsMetric.Register("ga:percentVisitsWithSearch", "Internal Search", true);

        /// <summary>
        /// Gets the total number of subsequent page views made after a use of your internal search feature (id: <code>ga:searchDepth)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchdepth</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchDepth = AnalyticsMetric.Register("ga:searchDepth", "Internal Search");

        /// <summary>
        /// Gets the average number of pages people viewed after performing a search (id: <code>ga:avgSearchDepth)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_avgsearchdepth</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgSearchDepth = AnalyticsMetric.Register("ga:avgSearchDepth", "Internal Search");

        /// <summary>
        /// Gets the total number of times a refinement (transition) occurs between internal search keywords within a session. For example if the sequence of keywords is: "shoes", "shoes", "pants", "pants", this metric will be one because the transition between "shoes" and "pants" is different (id: <code>ga:searchRefinements)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchrefinements</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchRefinements = AnalyticsMetric.Register("ga:searchRefinements", "Internal Search");

        /// <summary>
        /// Gets the percentage of number of times a refinement (i.e., transition) occurs between internal search keywords within a session (id: <code>ga:percentSearchRefinements)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_percentsearchrefinements</cref>
        /// </see>
        public static readonly AnalyticsMetric PercentSearchRefinements = AnalyticsMetric.Register("ga:percentSearchRefinements", "Internal Search");

        /// <summary>
        /// Gets the session duration where a use of your internal search feature occurred (id: <code>ga:searchDuration)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchduration</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchDuration = AnalyticsMetric.Register("ga:searchDuration", "Internal Search");

        /// <summary>
        /// Gets the average time (in seconds) users spent on your property after searching (id: <code>ga:avgSearchDuration)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_avgsearchduration</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgSearchDuration = AnalyticsMetric.Register("ga:avgSearchDuration", "Internal Search");

        /// <summary>
        /// Gets the number of exits on your site that occurred following a search result from your internal search feature (id: <code>ga:searchExits)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchexits</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchExits = AnalyticsMetric.Register("ga:searchExits", "Internal Search");

        /// <summary>
        /// Gets the percentage of searches that resulted in an immediate exit from your property (id: <code>ga:searchExitRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchexitrate</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchExitRate = AnalyticsMetric.Register("ga:searchExitRate", "Internal Search");

        /// <summary>
        /// Gets the percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number (id: <code>ga:searchGoalXXConversionRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchgoalxxconversionrate</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchGoalXXConversionRate = AnalyticsMetric.Register("ga:searchGoalXXConversionRate", "Internal Search");

        /// <summary>
        /// Gets the percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to at least one of your goals (id: <code>ga:searchGoalConversionRateAll)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_searchgoalconversionrateall</cref>
        /// </see>
        public static readonly AnalyticsMetric SearchGoalConversionRateAll = AnalyticsMetric.Register("ga:searchGoalConversionRateAll", "Internal Search");

        /// <summary>
        /// Gets the average goal value of a search (id: <code>ga:goalValueAllPerSearch)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=internal_search&amp;jump=ga_goalvalueallpersearch</cref>
        /// </see>
        public static readonly AnalyticsMetric GoalValueAllPerSearch = AnalyticsMetric.Register("ga:goalValueAllPerSearch", "Internal Search");

        #endregion

        #region Site Speed

        /// <summary>
        /// Gets the total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser (id: <code>ga:pageLoadTime)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_pageloadtime</cref>
        /// </see>
        public static readonly AnalyticsMetric PageLoadTime = AnalyticsMetric.Register("ga:pageLoadTime", "Site Speed");

        /// <summary>
        /// Gets the sample set (or count) of pageviews used to calculate the average page load time (id: <code>ga:pageLoadSample)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_pageloadsample</cref>
        /// </see>
        public static readonly AnalyticsMetric PageLoadSample = AnalyticsMetric.Register("ga:pageLoadSample", "Site Speed");

        /// <summary>
        /// Gets the average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser (id: <code>ga:avgPageLoadTime)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgpageloadtime</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgPageLoadTime = AnalyticsMetric.Register("ga:avgPageLoadTime", "Site Speed");

        /// <summary>
        /// Gets the total amount of time (in milliseconds) spent in DNS lookup for this page among all samples (id: <code>ga:domainLookupTime)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_domainlookuptime</cref>
        /// </see>
        public static readonly AnalyticsMetric DomainLookupTime = AnalyticsMetric.Register("ga:domainLookupTime", "Site Speed");

        /// <summary>
        /// Gets the average amount of time (in seconds) spent in DNS lookup for this page (id: <code>ga:avgDomainLookupTime)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgdomainlookuptime</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgDomainLookupTime = AnalyticsMetric.Register("ga:avgDomainLookupTime", "Site Speed");

        /// <summary>
        /// Gets the total amount of time (in milliseconds) to download this page among all samples (id: <code>ga:pageDownloadTime)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_pagedownloadtime</cref>
        /// </see>
        public static readonly AnalyticsMetric PageDownloadTime = AnalyticsMetric.Register("ga:pageDownloadTime", "Site Speed");

        /// <summary>
        /// Gets the average amount of time (in seconds) to download this page (id: <code>ga:avgPageDownloadTime)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgpagedownloadtime</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgPageDownloadTime = AnalyticsMetric.Register("ga:avgPageDownloadTime", "Site Speed");

        /// <summary>
        /// Gets the total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0 (id: <code>ga:redirectionTime)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_redirectiontime</cref>
        /// </see>
        public static readonly AnalyticsMetric RedirectionTime = AnalyticsMetric.Register("ga:redirectionTime", "Site Speed");

        /// <summary>
        /// Gets the average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0 (id: <code>ga:avgRedirectionTime)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgredirectiontime</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgRedirectionTime = AnalyticsMetric.Register("ga:avgRedirectionTime", "Site Speed");

        /// <summary>
        /// Gets the total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples (id: <code>ga:serverConnectionTime)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_serverconnectiontime</cref>
        /// </see>
        public static readonly AnalyticsMetric ServerConnectionTime = AnalyticsMetric.Register("ga:serverConnectionTime", "Site Speed");

        /// <summary>
        /// Gets the average amount of time (in seconds) spent in establishing TCP connection for this page (id: <code>ga:avgServerConnectionTime)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgserverconnectiontime</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgServerConnectionTime = AnalyticsMetric.Register("ga:avgServerConnectionTime", "Site Speed");

        /// <summary>
        /// Gets the total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server (id: <code>ga:serverResponseTime)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_serverresponsetime</cref>
        /// </see>
        public static readonly AnalyticsMetric ServerResponseTime = AnalyticsMetric.Register("ga:serverResponseTime", "Site Speed");

        /// <summary>
        /// Gets the average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server (id: <code>ga:avgServerResponseTime)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgserverresponsetime</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgServerResponseTime = AnalyticsMetric.Register("ga:avgServerResponseTime", "Site Speed");

        /// <summary>
        /// Gets the sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime (id: <code>ga:speedMetricsSample)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_speedmetricssample</cref>
        /// </see>
        public static readonly AnalyticsMetric SpeedMetricsSample = AnalyticsMetric.Register("ga:speedMetricsSample", "Site Speed");

        /// <summary>
        /// Gets the time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded (id: <code>ga:domInteractiveTime)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_dominteractivetime</cref>
        /// </see>
        public static readonly AnalyticsMetric DomInteractiveTime = AnalyticsMetric.Register("ga:domInteractiveTime", "Site Speed");

        /// <summary>
        /// Gets the average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server (id: <code>ga:avgDomInteractiveTime)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgdominteractivetime</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgDomInteractiveTime = AnalyticsMetric.Register("ga:avgDomInteractiveTime", "Site Speed");

        /// <summary>
        /// Gets the time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc (id: <code>ga:domContentLoadedTime)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_domcontentloadedtime</cref>
        /// </see>
        public static readonly AnalyticsMetric DomContentLoadedTime = AnalyticsMetric.Register("ga:domContentLoadedTime", "Site Speed");

        /// <summary>
        /// Gets the average time (in seconds) it takes the browser to parse the document (id: <code>ga:avgDomContentLoadedTime)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_avgdomcontentloadedtime</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgDomContentLoadedTime = AnalyticsMetric.Register("ga:avgDomContentLoadedTime", "Site Speed");

        /// <summary>
        /// Gets the sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations (id: <code>ga:domLatencyMetricsSample)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=site_speed&amp;jump=ga_domlatencymetricssample</cref>
        /// </see>
        public static readonly AnalyticsMetric DomLatencyMetricsSample = AnalyticsMetric.Register("ga:domLatencyMetricsSample", "Site Speed");

        #endregion

        #region App Tracking

        /// <summary>
        /// Gets the total number of screenviews (id: <code>ga:screenviews</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_screenviews</cref>
        /// </see>
        public static readonly AnalyticsMetric Screenviews = AnalyticsMetric.Register("ga:screenviews", "App Tracking");

        /// <summary>
        /// Gets the total number of screenviews (id: <code>ga:appviews</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appviews</cref>
        /// </see>
        [Obsolete("Use ga:screenviews instead.")]
        public static readonly AnalyticsMetric Appviews = AnalyticsMetric.Register("ga:appviews", "App Tracking", true);

        /// <summary>
        /// Gets the number of unique screen views. Screen views in different sessions count a separate screen views (id: <code>ga:uniqueScreenviews)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_uniquescreenviews</cref>
        /// </see>
        public static readonly AnalyticsMetric UniqueScreenviews = AnalyticsMetric.Register("ga:uniqueScreenviews", "App Tracking");

        /// <summary>
        /// Gets the number of unique screen views. Screen views in different sessions count a separate screen views (id: <code>ga:uniqueAppviews)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_uniqueappviews</cref>
        /// </see>
        [Obsolete("Use ga:uniqueScreenviews instead.")]
        public static readonly AnalyticsMetric UniqueAppviews = AnalyticsMetric.Register("ga:uniqueAppviews", "App Tracking", true);

        /// <summary>
        /// Gets the average number of screenviews per session (id: <code>ga:screenviewsPerSession)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_screenviewspersession</cref>
        /// </see>
        public static readonly AnalyticsMetric ScreenviewsPerSession = AnalyticsMetric.Register("ga:screenviewsPerSession", "App Tracking");

        /// <summary>
        /// Gets the average number of screenviews per session (id: <code>ga:appviewsPerVisit)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_appviewspervisit</cref>
        /// </see>
        [Obsolete("Use ga:screenviewsPerSession instead.")]
        public static readonly AnalyticsMetric AppviewsPerVisit = AnalyticsMetric.Register("ga:appviewsPerVisit", "App Tracking", true);

        /// <summary>
        /// Gets the time spent viewing the current screen (id: <code>ga:timeOnScreen)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_timeonscreen</cref>
        /// </see>
        public static readonly AnalyticsMetric TimeOnScreen = AnalyticsMetric.Register("ga:timeOnScreen", "App Tracking");

        /// <summary>
        /// Gets the average amount of time users spent on a screen in seconds (id: <code>ga:avgScreenviewDuration)</code>, type: <code>time</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=app_tracking&amp;jump=ga_avgscreenviewduration</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgScreenviewDuration = AnalyticsMetric.Register("ga:avgScreenviewDuration", "App Tracking");

        #endregion

        #region Event Tracking

        /// <summary>
        /// Gets the total number of events for the profile, across all categories (id: <code>ga:totalEvents)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_totalevents</cref>
        /// </see>
        public static readonly AnalyticsMetric TotalEvents = AnalyticsMetric.Register("ga:totalEvents", "Event Tracking");

        /// <summary>
        /// Gets the number of unique events. Events in different sessions count as separate events (id: <code>ga:uniqueEvents)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_uniqueevents</cref>
        /// </see>
        public static readonly AnalyticsMetric UniqueEvents = AnalyticsMetric.Register("ga:uniqueEvents", "Event Tracking");

        /// <summary>
        /// Gets the total value of events for the profile (id: <code>ga:eventValue)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventvalue</cref>
        /// </see>
        public static readonly AnalyticsMetric EventValue = AnalyticsMetric.Register("ga:eventValue", "Event Tracking");

        /// <summary>
        /// Gets the average value of an event (id: <code>ga:avgEventValue)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_avgeventvalue</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgEventValue = AnalyticsMetric.Register("ga:avgEventValue", "Event Tracking");

        /// <summary>
        /// Gets the total number of sessions with events (id: <code>ga:sessionsWithEvent)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_sessionswithevent</cref>
        /// </see>
        public static readonly AnalyticsMetric SessionsWithEvent = AnalyticsMetric.Register("ga:sessionsWithEvent", "Event Tracking");

        /// <summary>
        /// Gets the total number of sessions with events (id: <code>ga:visitsWithEvent)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_visitswithevent</cref>
        /// </see>
        [Obsolete("Use ga:sessionsWithEvent instead.")]
        public static readonly AnalyticsMetric VisitsWithEvent = AnalyticsMetric.Register("ga:visitsWithEvent", "Event Tracking", true);

        /// <summary>
        /// Gets the average number of events per session with event (id: <code>ga:eventsPerSessionWithEvent)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventspersessionwithevent</cref>
        /// </see>
        public static readonly AnalyticsMetric EventsPerSessionWithEvent = AnalyticsMetric.Register("ga:eventsPerSessionWithEvent", "Event Tracking");

        /// <summary>
        /// Gets the average number of events per session with event (id: <code>ga:eventsPerVisitWithEvent)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=event_tracking&amp;jump=ga_eventspervisitwithevent</cref>
        /// </see>
        [Obsolete("Use ga:eventsPerSessionWithEvent instead.")]
        public static readonly AnalyticsMetric EventsPerVisitWithEvent = AnalyticsMetric.Register("ga:eventsPerVisitWithEvent", "Event Tracking", true);

        #endregion

        #region Ecommerce

        /// <summary>
        /// Gets the total number of transactions (id: <code>ga:transactions</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactions</cref>
        /// </see>
        public static readonly AnalyticsMetric Transactions = AnalyticsMetric.Register("ga:transactions", "Ecommerce");

        /// <summary>
        /// Gets the average number of transactions for a session (id: <code>ga:transactionsPerSession)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionspersession</cref>
        /// </see>
        public static readonly AnalyticsMetric TransactionsPerSession = AnalyticsMetric.Register("ga:transactionsPerSession", "Ecommerce");

        /// <summary>
        /// Gets the average number of transactions for a session (id: <code>ga:transactionsPerVisit)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionspervisit</cref>
        /// </see>
        [Obsolete("Use ga:transactionsPerSession instead.")]
        public static readonly AnalyticsMetric TransactionsPerVisit = AnalyticsMetric.Register("ga:transactionsPerVisit", "Ecommerce", true);

        /// <summary>
        /// Gets the total sale revenue provided in the transaction excluding shipping and tax (id: <code>ga:transactionRevenue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionrevenue</cref>
        /// </see>
        public static readonly AnalyticsMetric TransactionRevenue = AnalyticsMetric.Register("ga:transactionRevenue", "Ecommerce");

        /// <summary>
        /// Gets the average revenue for an e-commerce transaction (id: <code>ga:revenuePerTransaction)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_revenuepertransaction</cref>
        /// </see>
        public static readonly AnalyticsMetric RevenuePerTransaction = AnalyticsMetric.Register("ga:revenuePerTransaction", "Ecommerce");

        /// <summary>
        /// Average transaction revenue for a session (id: <code>ga:transactionRevenuePerSession)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionrevenuepersession</cref>
        /// </see>
        public static readonly AnalyticsMetric TransactionRevenuePerSession = AnalyticsMetric.Register("ga:transactionRevenuePerSession", "Ecommerce");

        /// <summary>
        /// Average transaction revenue for a session (id: <code>ga:transactionRevenuePerVisit)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionrevenuepervisit</cref>
        /// </see>
        [Obsolete("Use ga:transactionRevenuePerSession instead.")]
        public static readonly AnalyticsMetric TransactionRevenuePerVisit = AnalyticsMetric.Register("ga:transactionRevenuePerVisit", "Ecommerce", true);

        /// <summary>
        /// Gets the total cost of shipping (id: <code>ga:transactionShipping)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionshipping</cref>
        /// </see>
        public static readonly AnalyticsMetric TransactionShipping = AnalyticsMetric.Register("ga:transactionShipping", "Ecommerce");

        /// <summary>
        /// Gets the total amount of tax (id: <code>ga:transactionTax)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactiontax</cref>
        /// </see>
        public static readonly AnalyticsMetric TransactionTax = AnalyticsMetric.Register("ga:transactionTax", "Ecommerce");

        /// <summary>
        /// Gets the total value for your property (including total revenue and total goal value) (id: <code>ga:totalValue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_totalvalue</cref>
        /// </see>
        public static readonly AnalyticsMetric TotalValue = AnalyticsMetric.Register("ga:totalValue", "Ecommerce");

        /// <summary>
        /// Gets the total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased (id: <code>ga:itemQuantity)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_itemquantity</cref>
        /// </see>
        public static readonly AnalyticsMetric ItemQuantity = AnalyticsMetric.Register("ga:itemQuantity", "Ecommerce");

        /// <summary>
        /// Gets the number of product sets purchased. For example, if users purchase 2 frisbees and 5 tennis balls from your site, 2 unique products have been purchased (id: <code>ga:uniquePurchases)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_uniquepurchases</cref>
        /// </see>
        public static readonly AnalyticsMetric UniquePurchases = AnalyticsMetric.Register("ga:uniquePurchases", "Ecommerce");

        /// <summary>
        /// Gets the average revenue per item (id: <code>ga:revenuePerItem)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_revenueperitem</cref>
        /// </see>
        public static readonly AnalyticsMetric RevenuePerItem = AnalyticsMetric.Register("ga:revenuePerItem", "Ecommerce");

        /// <summary>
        /// Gets the total revenue from purchased product items (id: <code>ga:itemRevenue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_itemrevenue</cref>
        /// </see>
        public static readonly AnalyticsMetric ItemRevenue = AnalyticsMetric.Register("ga:itemRevenue", "Ecommerce");

        /// <summary>
        /// Gets the average quantity of this item (or group of items) sold per purchase (id: <code>ga:itemsPerPurchase)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_itemsperpurchase</cref>
        /// </see>
        public static readonly AnalyticsMetric ItemsPerPurchase = AnalyticsMetric.Register("ga:itemsPerPurchase", "Ecommerce");

        /// <summary>
        /// Transaction revenue in local currency (id: <code>ga:localTransactionRevenue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localtransactionrevenue</cref>
        /// </see>
        public static readonly AnalyticsMetric LocalTransactionRevenue = AnalyticsMetric.Register("ga:localTransactionRevenue", "Ecommerce");

        /// <summary>
        /// Transaction shipping cost in local currency (id: <code>ga:localTransactionShipping)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localtransactionshipping</cref>
        /// </see>
        public static readonly AnalyticsMetric LocalTransactionShipping = AnalyticsMetric.Register("ga:localTransactionShipping", "Ecommerce");

        /// <summary>
        /// Transaction tax in local currency (id: <code>ga:localTransactionTax)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localtransactiontax</cref>
        /// </see>
        public static readonly AnalyticsMetric LocalTransactionTax = AnalyticsMetric.Register("ga:localTransactionTax", "Ecommerce");

        /// <summary>
        /// Product revenue in local currency (id: <code>ga:localItemRevenue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localitemrevenue</cref>
        /// </see>
        public static readonly AnalyticsMetric LocalItemRevenue = AnalyticsMetric.Register("ga:localItemRevenue", "Ecommerce");

        /// <summary>
        /// Unique purchases divided by views of product detail pages (Enhanced Ecommerce) (id: <code>ga:buyToDetailRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_buytodetailrate</cref>
        /// </see>
        public static readonly AnalyticsMetric BuyToDetailRate = AnalyticsMetric.Register("ga:buyToDetailRate", "Ecommerce");

        /// <summary>
        /// Product adds divided by views of product details (Enhanced Ecommerce) (id: <code>ga:cartToDetailRate)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_carttodetailrate</cref>
        /// </see>
        public static readonly AnalyticsMetric CartToDetailRate = AnalyticsMetric.Register("ga:cartToDetailRate", "Ecommerce");

        /// <summary>
        /// Gets the rate at which users clicked through to view the internal promotion (<code>ga:internalPromotionClicks</code> / <code>ga:internalPromotionViews</code>) - (Enhanced Ecommerce) (id: <code>ga:internalPromotionCTR)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionctr</cref>
        /// </see>
        public static readonly AnalyticsMetric InternalPromotionCTR = AnalyticsMetric.Register("ga:internalPromotionCTR", "Ecommerce");

        /// <summary>
        /// Gets the number of clicks on an internal promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionClicks)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionclicks</cref>
        /// </see>
        public static readonly AnalyticsMetric InternalPromotionClicks = AnalyticsMetric.Register("ga:internalPromotionClicks", "Ecommerce");

        /// <summary>
        /// Gets the number of views of an internal promotion (Enhanced Ecommerce) (id: <code>ga:internalPromotionViews)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_internalpromotionviews</cref>
        /// </see>
        public static readonly AnalyticsMetric InternalPromotionViews = AnalyticsMetric.Register("ga:internalPromotionViews", "Ecommerce");

        /// <summary>
        /// Refund amount for a given product in the local currency (Enhanced Ecommerce) (id: <code>ga:localProductRefundAmount)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localproductrefundamount</cref>
        /// </see>
        public static readonly AnalyticsMetric LocalProductRefundAmount = AnalyticsMetric.Register("ga:localProductRefundAmount", "Ecommerce");

        /// <summary>
        /// Gets the total refund amount for the transaction in the local currency (Enhanced Ecommerce) (id: <code>ga:localRefundAmount)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_localrefundamount</cref>
        /// </see>
        public static readonly AnalyticsMetric LocalRefundAmount = AnalyticsMetric.Register("ga:localRefundAmount", "Ecommerce");

        /// <summary>
        /// Number of times the product was added to the shopping cart (Enhanced Ecommerce) (id: <code>ga:productAddsToCart)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productaddstocart</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductAddsToCart = AnalyticsMetric.Register("ga:productAddsToCart", "Ecommerce");

        /// <summary>
        /// Number of times the product was included in the check-out process (Enhanced Ecommerce) (id: <code>ga:productCheckouts)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productcheckouts</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductCheckouts = AnalyticsMetric.Register("ga:productCheckouts", "Ecommerce");

        /// <summary>
        /// Number of times users viewed the product-detail page (Enhanced Ecommerce) (id: <code>ga:productDetailViews)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productdetailviews</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductDetailViews = AnalyticsMetric.Register("ga:productDetailViews", "Ecommerce");

        /// <summary>
        /// Gets the rate at which users clicked through on the product in a product list (<code>ga:productListClicks</code> / <code>ga:productListViews</code>) - (Enhanced Ecommerce) (id: <code>ga:productListCTR)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistctr</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductListCTR = AnalyticsMetric.Register("ga:productListCTR", "Ecommerce");

        /// <summary>
        /// Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce) (id: <code>ga:productListClicks)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistclicks</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductListClicks = AnalyticsMetric.Register("ga:productListClicks", "Ecommerce");

        /// <summary>
        /// Number of times the product appeared in a product list (Enhanced Ecommerce) (id: <code>ga:productListViews)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productlistviews</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductListViews = AnalyticsMetric.Register("ga:productListViews", "Ecommerce");

        /// <summary>
        /// Gets the total refund amount associated with the product (Enhanced Ecommerce) (id: <code>ga:productRefundAmount)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productrefundamount</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductRefundAmount = AnalyticsMetric.Register("ga:productRefundAmount", "Ecommerce");

        /// <summary>
        /// Number of times a refund was issued for the product (Enhanced Ecommerce) (id: <code>ga:productRefunds)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productrefunds</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductRefunds = AnalyticsMetric.Register("ga:productRefunds", "Ecommerce");

        /// <summary>
        /// Number of times the product was removed from shopping cart (Enhanced Ecommerce) (id: <code>ga:productRemovesFromCart)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productremovesfromcart</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductRemovesFromCart = AnalyticsMetric.Register("ga:productRemovesFromCart", "Ecommerce");

        /// <summary>
        /// Average product revenue per purchase (commonly used with Product Coupon Code) (<code>ga:itemRevenue</code> / <code>ga:uniquePurchases</code>) - (Enhanced Ecommerce) (id: <code>ga:productRevenuePerPurchase)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_productrevenueperpurchase</cref>
        /// </see>
        public static readonly AnalyticsMetric ProductRevenuePerPurchase = AnalyticsMetric.Register("ga:productRevenuePerPurchase", "Ecommerce");

        /// <summary>
        /// Number of product units added to the shopping cart (Enhanced Ecommerce) (id: <code>ga:quantityAddedToCart)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_quantityaddedtocart</cref>
        /// </see>
        public static readonly AnalyticsMetric QuantityAddedToCart = AnalyticsMetric.Register("ga:quantityAddedToCart", "Ecommerce");

        /// <summary>
        /// Number of product units included in check out (Enhanced Ecommerce) (id: <code>ga:quantityCheckedOut)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_quantitycheckedout</cref>
        /// </see>
        public static readonly AnalyticsMetric QuantityCheckedOut = AnalyticsMetric.Register("ga:quantityCheckedOut", "Ecommerce");

        /// <summary>
        /// Number of product units refunded (Enhanced Ecommerce) (id: <code>ga:quantityRefunded)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_quantityrefunded</cref>
        /// </see>
        public static readonly AnalyticsMetric QuantityRefunded = AnalyticsMetric.Register("ga:quantityRefunded", "Ecommerce");

        /// <summary>
        /// Number of product units removed from cart (Enhanced Ecommerce) (id: <code>ga:quantityRemovedFromCart)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_quantityremovedfromcart</cref>
        /// </see>
        public static readonly AnalyticsMetric QuantityRemovedFromCart = AnalyticsMetric.Register("ga:quantityRemovedFromCart", "Ecommerce");

        /// <summary>
        /// Currency amount refunded for a transaction (Enhanced Ecommerce) (id: <code>ga:refundAmount)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_refundamount</cref>
        /// </see>
        public static readonly AnalyticsMetric RefundAmount = AnalyticsMetric.Register("ga:refundAmount", "Ecommerce");

        /// <summary>
        /// Gets the total sale revenue provided in the transaction excluding shipping and tax divided by the total number of users (id: <code>ga:revenuePerUser)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_revenueperuser</cref>
        /// </see>
        public static readonly AnalyticsMetric RevenuePerUser = AnalyticsMetric.Register("ga:revenuePerUser", "Ecommerce");

        /// <summary>
        /// Number of refunds that have been issued (Enhanced Ecommerce) (id: <code>ga:totalRefunds)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_totalrefunds</cref>
        /// </see>
        public static readonly AnalyticsMetric TotalRefunds = AnalyticsMetric.Register("ga:totalRefunds", "Ecommerce");

        /// <summary>
        /// Gets the total number of transactions divided by the total number of users (id: <code>ga:transactionsPerUser)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ecommerce&amp;jump=ga_transactionsperuser</cref>
        /// </see>
        public static readonly AnalyticsMetric TransactionsPerUser = AnalyticsMetric.Register("ga:transactionsPerUser", "Ecommerce");

        #endregion

        #region Social Interactions

        /// <summary>
        /// Gets the total number of social interactions (id: <code>ga:socialInteractions)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractions</cref>
        /// </see>
        public static readonly AnalyticsMetric SocialInteractions = AnalyticsMetric.Register("ga:socialInteractions", "Social Interactions");

        /// <summary>
        /// Gets the number of sessions during which the specified social action(s) occurred at least once. This is based on the the unique combination of socialInteractionNetwork, socialInteractionAction, and socialInteractionTarget (id: <code>ga:uniqueSocialInteractions)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_uniquesocialinteractions</cref>
        /// </see>
        public static readonly AnalyticsMetric UniqueSocialInteractions = AnalyticsMetric.Register("ga:uniqueSocialInteractions", "Social Interactions");

        /// <summary>
        /// Gets the number of social interactions per session (id: <code>ga:socialInteractionsPerSession)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionspersession</cref>
        /// </see>
        public static readonly AnalyticsMetric SocialInteractionsPerSession = AnalyticsMetric.Register("ga:socialInteractionsPerSession", "Social Interactions");

        /// <summary>
        /// Gets the number of social interactions per session (id: <code>ga:socialInteractionsPerVisit)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=social_interactions&amp;jump=ga_socialinteractionspervisit</cref>
        /// </see>
        [Obsolete("Use ga:socialInteractionsPerSession instead.")]
        public static readonly AnalyticsMetric SocialInteractionsPerVisit = AnalyticsMetric.Register("ga:socialInteractionsPerVisit", "Social Interactions", true);

        #endregion

        #region User Timings

        /// <summary>
        /// Gets the total number of milliseconds for a user timing (id: <code>ga:userTimingValue)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertimingvalue</cref>
        /// </see>
        public static readonly AnalyticsMetric UserTimingValue = AnalyticsMetric.Register("ga:userTimingValue", "User Timings");

        /// <summary>
        /// Gets the number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable (id: <code>ga:userTimingSample)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_usertimingsample</cref>
        /// </see>
        public static readonly AnalyticsMetric UserTimingSample = AnalyticsMetric.Register("ga:userTimingSample", "User Timings");

        /// <summary>
        /// Gets the average amount of elapsed time (id: <code>ga:avgUserTimingValue)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=user_timings&amp;jump=ga_avgusertimingvalue</cref>
        /// </see>
        public static readonly AnalyticsMetric AvgUserTimingValue = AnalyticsMetric.Register("ga:avgUserTimingValue", "User Timings");

        #endregion

        #region Exceptions

        /// <summary>
        /// Gets the number of exceptions that were sent to Google Analytics (id: <code>ga:exceptions</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_exceptions</cref>
        /// </see>
        public static readonly AnalyticsMetric Exceptions = AnalyticsMetric.Register("ga:exceptions", "Exceptions");

        /// <summary>
        /// Gets the number of exceptions thrown divided by the number of screenviews (id: <code>ga:exceptionsPerScreenview)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_exceptionsperscreenview</cref>
        /// </see>
        public static readonly AnalyticsMetric ExceptionsPerScreenview = AnalyticsMetric.Register("ga:exceptionsPerScreenview", "Exceptions");

        /// <summary>
        /// Gets the number of exceptions where isFatal is set to true (id: <code>ga:fatalExceptions)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_fatalexceptions</cref>
        /// </see>
        public static readonly AnalyticsMetric FatalExceptions = AnalyticsMetric.Register("ga:fatalExceptions", "Exceptions");

        /// <summary>
        /// Gets the number of fatal exceptions thrown divided by the number of screenviews (id: <code>ga:fatalExceptionsPerScreenview)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=exceptions&amp;jump=ga_fatalexceptionsperscreenview</cref>
        /// </see>
        public static readonly AnalyticsMetric FatalExceptionsPerScreenview = AnalyticsMetric.Register("ga:fatalExceptionsPerScreenview", "Exceptions");

        #endregion

        #region Custom Variables or Columns

        /// <summary>
        /// Gets the name of the requested custom metric, where XX refers the number/index of the custom metric. Note that the data type of <code>ga:metricXX</code> can be INTEGER, CURRENCY or TIME (id: <code>ga:metricXX)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=custom_variables_or_columns&amp;jump=ga_metricxx</cref>
        /// </see>
        public static readonly AnalyticsMetric MetricXX = AnalyticsMetric.Register("ga:metricXX", "Custom Variables or Columns");

        #endregion

        #region DoubleClick Campaign Manager

        /// <summary>
        /// Gets the number of DCM Floodlight conversions (premium only) (id: <code>ga:dcmFloodlightQuantity)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightquantity</cref>
        /// </see>
        public static readonly AnalyticsMetric DcmFloodlightQuantity = AnalyticsMetric.Register("ga:dcmFloodlightQuantity", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Floodlight revenue (premium only) (id: <code>ga:dcmFloodlightRevenue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmfloodlightrevenue</cref>
        /// </see>
        public static readonly AnalyticsMetric DcmFloodlightRevenue = AnalyticsMetric.Register("ga:dcmFloodlightRevenue", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Cost Per Click (premium only) (id: <code>ga:dcmCPC)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmcpc</cref>
        /// </see>
        public static readonly AnalyticsMetric DcmCPC = AnalyticsMetric.Register("ga:dcmCPC", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Click Through Rate (premium only) (id: <code>ga:dcmCTR)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmctr</cref>
        /// </see>
        public static readonly AnalyticsMetric DcmCTR = AnalyticsMetric.Register("ga:dcmCTR", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Total Clicks (premium only) (id: <code>ga:dcmClicks)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmclicks</cref>
        /// </see>
        public static readonly AnalyticsMetric DcmClicks = AnalyticsMetric.Register("ga:dcmClicks", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Total Cost (premium only) (id: <code>ga:dcmCost)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmcost</cref>
        /// </see>
        public static readonly AnalyticsMetric DcmCost = AnalyticsMetric.Register("ga:dcmCost", "DoubleClick Campaign Manager");

        /// <summary>
        /// DCM Total Impressions (premium only) (id: <code>ga:dcmImpressions)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmimpressions</cref>
        /// </see>
        public static readonly AnalyticsMetric DcmImpressions = AnalyticsMetric.Register("ga:dcmImpressions", "DoubleClick Campaign Manager");

        /// <summary>
        /// This metric is deprecated and will be removed soon. Please use <code>ga:dcmROAS</code> instead (id: <code>ga:dcmMargin)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmmargin</cref>
        /// </see>
        [Obsolete]
        public static readonly AnalyticsMetric DcmMargin = AnalyticsMetric.Register("ga:dcmMargin", "DoubleClick Campaign Manager", true);

        /// <summary>
        /// DCM Return On Ad Spend (ROAS) (premium only) (id: <code>ga:dcmROAS)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmroas</cref>
        /// </see>
        public static readonly AnalyticsMetric DcmROAS = AnalyticsMetric.Register("ga:dcmROAS", "DoubleClick Campaign Manager");

        /// <summary>
        /// This metric is deprecated and will be removed soon. Please use <code>ga:dcmROAS</code> instead (id: <code>ga:dcmROI)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmroi</cref>
        /// </see>
        [Obsolete]
        public static readonly AnalyticsMetric DcmROI = AnalyticsMetric.Register("ga:dcmROI", "DoubleClick Campaign Manager", true);

        /// <summary>
        /// DCM Revenue Per Click (premium only) (id: <code>ga:dcmRPC)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=double_click_campaign_manager&amp;jump=ga_dcmrpc</cref>
        /// </see>
        public static readonly AnalyticsMetric DcmRPC = AnalyticsMetric.Register("ga:dcmRPC", "DoubleClick Campaign Manager");

        #endregion

        #region Adsense

        /// <summary>
        /// Gets the total revenue from AdSense ads (id: <code>ga:adsenseRevenue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenserevenue</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsenseRevenue = AnalyticsMetric.Register("ga:adsenseRevenue", "Adsense");

        /// <summary>
        /// Gets the number of AdSense ad units viewed. An Ad unit is a set of ads displayed as a result of one piece of the AdSense ad code. Details: https://support.google.com/adsense/answer/32715?hl=en (id: <code>ga:adsenseAdUnitsViewed)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseadunitsviewed</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsenseAdUnitsViewed = AnalyticsMetric.Register("ga:adsenseAdUnitsViewed", "Adsense");

        /// <summary>
        /// Gets the number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit (id: <code>ga:adsenseAdsViewed)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseadsviewed</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsenseAdsViewed = AnalyticsMetric.Register("ga:adsenseAdsViewed", "Adsense");

        /// <summary>
        /// Gets the number of times AdSense ads on your site were clicked (id: <code>ga:adsenseAdsClicks)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseadsclicks</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsenseAdsClicks = AnalyticsMetric.Register("ga:adsenseAdsClicks", "Adsense");

        /// <summary>
        /// Gets the number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units (id: <code>ga:adsensePageImpressions)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsensepageimpressions</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsensePageImpressions = AnalyticsMetric.Register("ga:adsensePageImpressions", "Adsense");

        /// <summary>
        /// Gets the percentage of page impressions that resulted in a click on an AdSense ad (id: <code>ga:adsenseCTR)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsensectr</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsenseCTR = AnalyticsMetric.Register("ga:adsenseCTR", "Adsense");

        /// <summary>
        /// Gets the estimated cost per thousand page impressions. It is your AdSense Revenue per 1000 page impressions (id: <code>ga:adsenseECPM)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseecpm</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsenseECPM = AnalyticsMetric.Register("ga:adsenseECPM", "Adsense");

        /// <summary>
        /// Gets the number of sessions that ended due to a user clicking on an AdSense ad (id: <code>ga:adsenseExits)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseexits</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsenseExits = AnalyticsMetric.Register("ga:adsenseExits", "Adsense");

        /// <summary>
        /// Gets the percentage of impressions that were viewable (id: <code>ga:adsenseViewableImpressionPercent)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsenseviewableimpressionpercent</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsenseViewableImpressionPercent = AnalyticsMetric.Register("ga:adsenseViewableImpressionPercent", "Adsense");

        /// <summary>
        /// Gets the percentage of ad requests that returned at least one ad (id: <code>ga:adsenseCoverage)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=adsense&amp;jump=ga_adsensecoverage</cref>
        /// </see>
        public static readonly AnalyticsMetric AdsenseCoverage = AnalyticsMetric.Register("ga:adsenseCoverage", "Adsense");

        #endregion

        #region Ad Exchange

        /// <summary>
        /// An AdX ad impression is reported whenever an individual ad is displayed on your website. For example, if a page with two ad units is viewed once, we'll display two impressions (id: <code>ga:adxImpressions)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adximpressions</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxImpressions = AnalyticsMetric.Register("ga:adxImpressions", "Ad Exchange");

        /// <summary>
        /// Coverage is the percentage of ad requests that returned at least one ad. Generally, coverage can help you identify sites where your AdX account isn't able to provide targeted ads. (Ad Impressions / Total Ad Requests) * 100 (id: <code>ga:adxCoverage)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxcoverage</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxCoverage = AnalyticsMetric.Register("ga:adxCoverage", "Ad Exchange");

        /// <summary>
        /// Monetized Pageviews measures the total number of pageviews on your property that were shown with an ad from your linked AdX account. Note - a single page can have multiple ad units (id: <code>ga:adxMonetizedPageviews)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxmonetizedpageviews</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxMonetizedPageviews = AnalyticsMetric.Register("ga:adxMonetizedPageviews", "Ad Exchange");

        /// <summary>
        /// Gets the ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions) (id: <code>ga:adxImpressionsPerSession)</code>, type: <code>float</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adximpressionspersession</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxImpressionsPerSession = AnalyticsMetric.Register("ga:adxImpressionsPerSession", "Ad Exchange");

        /// <summary>
        /// Gets the percentage of ad impressions that were viewable. An impression is considered a viewable impression when it has appeared within a user's browser and had the opportunity to be seen (id: <code>ga:adxViewableImpressionsPercent)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxviewableimpressionspercent</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxViewableImpressionsPercent = AnalyticsMetric.Register("ga:adxViewableImpressionsPercent", "Ad Exchange");

        /// <summary>
        /// Gets the number of times AdX ads were clicked on your site (id: <code>ga:adxClicks)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxclicks</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxClicks = AnalyticsMetric.Register("ga:adxClicks", "Ad Exchange");

        /// <summary>
        /// Gets the percentage of pageviews that resulted in a click on an AdX ad (id: <code>ga:adxCTR)</code>, type: <code>percent</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxctr</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxCTR = AnalyticsMetric.Register("ga:adxCTR", "Ad Exchange");

        /// <summary>
        /// Gets the total estimated revenue from AdX ads (id: <code>ga:adxRevenue)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxrevenue</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxRevenue = AnalyticsMetric.Register("ga:adxRevenue", "Ad Exchange");

        /// <summary>
        /// Gets the total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to your site and not ad impressions (id: <code>ga:adxRevenuePer1000Sessions)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxrevenueper1000sessions</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxRevenuePer1000Sessions = AnalyticsMetric.Register("ga:adxRevenuePer1000Sessions", "Ad Exchange");

        /// <summary>
        /// Gets the effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews (id: <code>ga:adxECPM)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=ad_exchange&amp;jump=ga_adxecpm</cref>
        /// </see>
        public static readonly AnalyticsMetric AdxECPM = AnalyticsMetric.Register("ga:adxECPM", "Ad Exchange");

        #endregion

        #region Related Products

        /// <summary>
        /// Correlation Score for related products (id: <code>ga:correlationScore)</code>, type: <code>currency</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_correlationscore</cref>
        /// </see>
        public static readonly AnalyticsMetric CorrelationScore = AnalyticsMetric.Register("ga:correlationScore", "Related Products");

        /// <summary>
        /// Quantity of the product being queried (id: <code>ga:queryProductQuantity)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_queryproductquantity</cref>
        /// </see>
        public static readonly AnalyticsMetric QueryProductQuantity = AnalyticsMetric.Register("ga:queryProductQuantity", "Related Products");

        /// <summary>
        /// Quantity of the related product (id: <code>ga:relatedProductQuantity)</code>, type: <code>integer</code>).
        /// </summary>
        /// <see>
        ///     <cref>https://developers.google.com/analytics/devguides/reporting/core/dimsmets#view=detail&amp;group=related_products&amp;jump=ga_relatedproductquantity</cref>
        /// </see>
        public static readonly AnalyticsMetric RelatedProductQuantity = AnalyticsMetric.Register("ga:relatedProductQuantity", "Related Products");

        #endregion

        // ReSharper restore InconsistentNaming

        #pragma warning disable 612
        #pragma warning disable 618

        /// <summary>
        /// Gets an array will all metrics.
        /// </summary>
        public static AnalyticsMetric[] GetAll() {
            return new [] {
                Users, Visitors, NewUsers, NewVisits, PercentNewSessions, PercentNewVisits, Day1Users, Day7Users,
                Day14Users, Day30Users, SessionsPerUser, Sessions, Visits, Bounces, EntranceBounceRate, BounceRate,
                VisitBounceRate, SessionDuration, TimeOnSite, AvgSessionDuration, AvgTimeOnSite, Hits,
                OrganicSearches, Impressions, AdClicks, AdCost, CPM, CPC, CTR, CostPerTransaction,
                CostPerGoalConversion, CostPerConversion, RPC, ROI, Margin, ROAS, GoalXXStarts, GoalStartsAll,
                GoalXXCompletions, GoalCompletionsAll, GoalXXValue, GoalValueAll, GoalValuePerSession,
                GoalValuePerVisit, GoalXXConversionRate, GoalConversionRateAll, GoalXXAbandons, GoalAbandonsAll,
                GoalXXAbandonRate, GoalAbandonRateAll, SocialActivities, PageValue, Entrances, EntranceRate,
                Pageviews, PageviewsPerSession, PageviewsPerVisit, UniquePageviews, TimeOnPage, AvgTimeOnPage, Exits,
                ExitRate, ContentGroupUniqueViewsXX, SearchResultViews, SearchUniques, AvgSearchResultViews,
                SearchSessions, SearchVisits, PercentSessionsWithSearch, PercentVisitsWithSearch, SearchDepth,
                AvgSearchDepth, SearchRefinements, PercentSearchRefinements, SearchDuration, AvgSearchDuration,
                SearchExits, SearchExitRate, SearchGoalXXConversionRate, SearchGoalConversionRateAll,
                GoalValueAllPerSearch, PageLoadTime, PageLoadSample, AvgPageLoadTime, DomainLookupTime,
                AvgDomainLookupTime, PageDownloadTime, AvgPageDownloadTime, RedirectionTime, AvgRedirectionTime,
                ServerConnectionTime, AvgServerConnectionTime, ServerResponseTime, AvgServerResponseTime,
                SpeedMetricsSample, DomInteractiveTime, AvgDomInteractiveTime, DomContentLoadedTime,
                AvgDomContentLoadedTime, DomLatencyMetricsSample, Screenviews, Appviews, UniqueScreenviews,
                UniqueAppviews, ScreenviewsPerSession, AppviewsPerVisit, TimeOnScreen, AvgScreenviewDuration,
                TotalEvents, UniqueEvents, EventValue, AvgEventValue, SessionsWithEvent, VisitsWithEvent,
                EventsPerSessionWithEvent, EventsPerVisitWithEvent, Transactions, TransactionsPerSession,
                TransactionsPerVisit, TransactionRevenue, RevenuePerTransaction, TransactionRevenuePerSession,
                TransactionRevenuePerVisit, TransactionShipping, TransactionTax, TotalValue, ItemQuantity,
                UniquePurchases, RevenuePerItem, ItemRevenue, ItemsPerPurchase, LocalTransactionRevenue,
                LocalTransactionShipping, LocalTransactionTax, LocalItemRevenue, BuyToDetailRate, CartToDetailRate,
                InternalPromotionCTR, InternalPromotionClicks, InternalPromotionViews, LocalProductRefundAmount,
                LocalRefundAmount, ProductAddsToCart, ProductCheckouts, ProductDetailViews, ProductListCTR,
                ProductListClicks, ProductListViews, ProductRefundAmount, ProductRefunds, ProductRemovesFromCart,
                ProductRevenuePerPurchase, QuantityAddedToCart, QuantityCheckedOut, QuantityRefunded,
                QuantityRemovedFromCart, RefundAmount, RevenuePerUser, TotalRefunds, TransactionsPerUser,
                SocialInteractions, UniqueSocialInteractions, SocialInteractionsPerSession,
                SocialInteractionsPerVisit, UserTimingValue, UserTimingSample, AvgUserTimingValue, Exceptions,
                ExceptionsPerScreenview, FatalExceptions, FatalExceptionsPerScreenview, MetricXX,
                DcmFloodlightQuantity, DcmFloodlightRevenue, DcmCPC, DcmCTR, DcmClicks, DcmCost, DcmImpressions,
                DcmMargin, DcmROAS, DcmROI, DcmRPC, AdsenseRevenue, AdsenseAdUnitsViewed, AdsenseAdsViewed,
                AdsenseAdsClicks, AdsensePageImpressions, AdsenseCTR, AdsenseECPM, AdsenseExits,
                AdsenseViewableImpressionPercent, AdsenseCoverage, AdxImpressions, AdxCoverage, AdxMonetizedPageviews,
                AdxImpressionsPerSession, AdxViewableImpressionsPercent, AdxClicks, AdxCTR, AdxRevenue,
                AdxRevenuePer1000Sessions, AdxECPM, CorrelationScore, QueryProductQuantity, RelatedProductQuantity
            };
        }

        #pragma warning restore 612
        #pragma warning restore 618

    }

}