// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class SendMessageTipRequest : TeaModel {
        [NameInMap("defaultView")]
        [Validation(Required=false)]
        public SendMessageTipRequestDefaultView DefaultView { get; set; }
        public class SendMessageTipRequestDefaultView : TeaModel {
            [NameInMap("actionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("actionUrl")]
            [Validation(Required=false)]
            public string ActionUrl { get; set; }

            [NameInMap("authCode")]
            [Validation(Required=false)]
            public string AuthCode { get; set; }

            [NameInMap("authMediaId")]
            [Validation(Required=false)]
            public string AuthMediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>闪读消息卡片1</para>
            /// </summary>
            [NameInMap("cardTitle")]
            [Validation(Required=false)]
            public string CardTitle { get; set; }

            [NameInMap("cardTitleColor")]
            [Validation(Required=false)]
            public string CardTitleColor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>查看详情</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("needShowUpdateTail")]
            [Validation(Required=false)]
            public string NeedShowUpdateTail { get; set; }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>闪读消息卡片2</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg_f9aae78558b34e20a5badead4c29244c_123</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidVcYPzxnAySJOMhYX2QDbLwUA==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("privateFieldMap")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateFieldMapValue> PrivateFieldMap { get; set; }

        [NameInMap("publicField")]
        [Validation(Required=false)]
        public SendMessageTipRequestPublicField PublicField { get; set; }
        public class SendMessageTipRequestPublicField : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk://dingtalkclient/page/link33</para>
            /// </summary>
            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>限时阅读5分钟</para>
            /// </summary>
            [NameInMap("durationDesc")]
            [Validation(Required=false)]
            public string DurationDesc { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("isExpired")]
            [Validation(Required=false)]
            public bool? IsExpired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk://dingtalkclient/page/linkxx</para>
            /// </summary>
            [NameInMap("readActionUrl")]
            [Validation(Required=false)]
            public string ReadActionUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>已查收 0/1</para>
            /// </summary>
            [NameInMap("readProgressDesc")]
            [Validation(Required=false)]
            public string ReadProgressDesc { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receiverUserId")]
        [Validation(Required=false)]
        public List<string> ReceiverUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0808541222161261721</para>
        /// </summary>
        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

    }

}
