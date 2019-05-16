﻿using System;
namespace TamTamBot.Model
{
    /// <summary>Type of chat. Dialog (one-on-one), chat or channel</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.37.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum ChatType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"dialog")]
        Dialog = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"chat")]
        Chat = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"channel")]
        Channel = 2,

    }
}
