 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Payload3 : MediaAttachmentPayload
    {
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Payload3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Payload3>(data);
        }

    }}