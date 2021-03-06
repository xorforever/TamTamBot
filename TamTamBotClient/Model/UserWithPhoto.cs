using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UserWithPhoto : User
    {
        /// <summary>URL of avatar</summary>
        [Newtonsoft.Json.JsonProperty("avatar_url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Avatar_url { get; set; }

        /// <summary>URL of avatar of a bigger size</summary>
        [Newtonsoft.Json.JsonProperty("full_avatar_url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Full_avatar_url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static UserWithPhoto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UserWithPhoto>(data);
        }

    }}