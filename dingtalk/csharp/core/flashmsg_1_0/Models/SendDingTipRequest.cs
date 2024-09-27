// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class SendDingTipRequest : TeaModel {
        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        [NameInMap("link")]
        [Validation(Required=false)]
        public SendDingTipRequestLink Link { get; set; }
        public class SendDingTipRequestLink : TeaModel {
            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk://dingtalkclient/page/link?pc_slide=true</para>
            /// </summary>
            [NameInMap("linkUrl")]
            [Validation(Required=false)]
            public string LinkUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>@lQLPDhrngMo4hi3NAZDNAZCwqp0RL2MfbesBqImWncBnAA2BCD</para>
            /// </summary>
            [NameInMap("picMediaId")]
            [Validation(Required=false)]
            public string PicMediaId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>今天 10:00后超期</para>
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg_f9aae78558b34e20a5badead4c29244c_223</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receiverUserId")]
        [Validation(Required=false)]
        public List<string> ReceiverUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>080854121612261721</para>
        /// </summary>
        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您有一条闪读消息，请注意查收XX</para>
        /// </summary>
        [NameInMap("textContent")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

    }

}
