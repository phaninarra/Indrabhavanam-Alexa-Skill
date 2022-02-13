using Newtonsoft.Json;
using System;
using Alexa.NET.Helpers;

namespace Alexa.NET.Request.Type
{
    [JsonConverter(typeof(RequestConverter))]
    public class Request
    {
        [JsonProperty("type",Required = Required.Always)]
        public string Type { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("timestamp"),JsonConverter(typeof(MixedDateTimeConverter))]
        public DateTime Timestamp { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("error")]
        public Error Error { get; set; }
    }
}