// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendPersonalMessageRequest : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("msgType")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidc4iLyQBuHFQRvzxznz204Q==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1662055829854977</para>
        /// </summary>
        [NameInMap("receiverUid")]
        [Validation(Required=false)]
        public string ReceiverUid { get; set; }

    }

}
