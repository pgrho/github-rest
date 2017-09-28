using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shipwreck.GithubClient
{
    [Serializable, DataContract]
    public class GollumPage
    {
        [DefaultValue(null)]
        [DataMember, JsonProperty("page_name")]
        public string PageName { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("title")]
        public string Title { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("summary")]
        public string Summary { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GollumPageAction Action { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("sha")]
        public string Sha { get; set; }

        [DefaultValue(null)]
        [DataMember, JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }
}