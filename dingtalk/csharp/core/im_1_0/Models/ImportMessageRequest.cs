// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ImportMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;月会通知&lt;@all&gt; &quot;,&quot;at&quot;:{&quot;atUserIds&quot;:[],&quot;isAtAll&quot;:true}}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axcf*-<em><b><b>-</b></b></em>-23da*</para>
        /// </summary>
        [NameInMap("importUuid")]
        [Validation(Required=false)]
        public string ImportUuid { get; set; }

        [NameInMap("msgReadStatusSetting")]
        [Validation(Required=false)]
        public bool? MsgReadStatusSetting { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("msgType")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidt*****Xa4K10w==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<string> Receivers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>013*****21312</para>
        /// </summary>
        [NameInMap("senderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

    }

}
