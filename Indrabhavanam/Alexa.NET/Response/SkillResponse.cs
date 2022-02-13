using Newtonsoft.Json;
using System.Collections.Generic;

namespace Alexa.NET.Response
{
    public class SsmlSkillResponse
    {
        [JsonRequired]
        [JsonProperty("response")]
        public SsmlResponse Response { get; set; }

        [JsonRequired]
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("sessionAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> SessionAttributes { get; set; }
    }

    public class PlainTextSkillResponse
    {
        [JsonRequired]
        [JsonProperty("response")]
        public PlainTextResponse Response { get; set; }

        [JsonRequired]
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("sessionAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> SessionAttributes { get; set; }
    }
}