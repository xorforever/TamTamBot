 using System;
using System.Collections.Generic;
using System.Text;

namespace TamTamBot
{   /// <summary>Request to attach audio to message. MUST be the only attachment in message</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.14.1.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AudioAttachmentRequest : AttachmentRequest
    {
        [Newtonsoft.Json.JsonProperty("payload", Required = Newtonsoft.Json.Required.Always)]
        public UploadedInfo Payload { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AudioAttachmentRequest FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AudioAttachmentRequest>(data);
        }

    }}