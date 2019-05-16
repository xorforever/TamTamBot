﻿using System;
namespace TamTamBot.Model
{
    /// <summary>After pressing this type of button client sends to server payload it contains</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CallbackButton : Button
    {
        /// <summary>Button payload</summary>
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(1024)]
        public string Payload { get; set; }

        /// <summary>Intent of button. Affects clients representation.</summary>
        [Newtonsoft.Json.JsonProperty("intent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Intent Intent { get; set; } = Intent.Default;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CallbackButton FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CallbackButton>(data);
        }

    }

    /// <summary>After pressing this type of button user follows the link it contains</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class LinkButton : Button
    {
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(256)]
        public string Url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LinkButton FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LinkButton>(data);
        }

    }

    /// <summary>After pressing this type of button client sends new message with attachment of current user geo location</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RequestGeoLocationButton : Button
    {
        /// <summary>If *true*, sends location without asking user's confirmation</summary>
        [Newtonsoft.Json.JsonProperty("quick", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Quick { get; set; } = false;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RequestGeoLocationButton FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RequestGeoLocationButton>(data);
        }

    }
}
