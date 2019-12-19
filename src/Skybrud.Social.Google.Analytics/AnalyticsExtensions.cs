using System;
using Skybrud.Social.Google.Analytics.Http;
using Skybrud.Social.Google.OAuth;

namespace Skybrud.Social.Google.Analytics {

    public static class AnalyticsExtensions {

        public static AnalyticsHttpClient Analytics(this GoogleOAuthClient client) {
            if (client == null) throw new ArgumentNullException(nameof(client));
            return client.GetApiClient(() => new AnalyticsHttpClient(client));
        }

        public static AnalyticsService Analytics(this GoogleService service) {
            if (service == null) throw new ArgumentNullException(nameof(service));
            return service.GetApiService(() => new AnalyticsService(service));
        }

    }

}