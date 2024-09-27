// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendTemplateInteractiveCardRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxx.com/.../">https://xxxx.com/.../</a></para>
        /// </summary>
        [NameInMap("callbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>根据具体的cardTemplateId参考文档格式</para>
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TuWenCard01</para>
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidXXXX</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cardXXXX01</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        [NameInMap("sendOptions")]
        [Validation(Required=false)]
        public SendTemplateInteractiveCardRequestSendOptions SendOptions { get; set; }
        public class SendTemplateInteractiveCardRequestSendOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("atAll")]
            [Validation(Required=false)]
            public bool? AtAll { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;nickName&quot;:&quot;张三&quot;,&quot;userId&quot;:&quot;userId0001&quot;},{&quot;nickName&quot;:&quot;李四&quot;,&quot;unionId&quot;:&quot;unionId001&quot;}]</para>
            /// </summary>
            [NameInMap("atUserListJson")]
            [Validation(Required=false)]
            public string AtUserListJson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("cardPropertyJson")]
            [Validation(Required=false)]
            public string CardPropertyJson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;userId&quot;:&quot;userId0001&quot;},{&quot;unionId&quot;:&quot;unionId001&quot;}]</para>
            /// </summary>
            [NameInMap("receiverListJson")]
            [Validation(Required=false)]
            public string ReceiverListJson { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>以userId为例：{&quot;userId&quot;:&quot;userId0001&quot;}；以unionId为例{&quot;unionId&quot;:&quot;unionId001&quot;}</para>
        /// </summary>
        [NameInMap("singleChatReceiver")]
        [Validation(Required=false)]
        public string SingleChatReceiver { get; set; }

    }

}
