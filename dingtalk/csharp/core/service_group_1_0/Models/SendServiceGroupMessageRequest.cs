// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendServiceGroupMessageRequest : TeaModel {
        [NameInMap("atDingtalkIds")]
        [Validation(Required=false)]
        public List<string> AtDingtalkIds { get; set; }

        [NameInMap("atMobiles")]
        [Validation(Required=false)]
        public List<string> AtMobiles { get; set; }

        [NameInMap("atUnionIds")]
        [Validation(Required=false)]
        public List<string> AtUnionIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("btnOrientation")]
        [Validation(Required=false)]
        public string BtnOrientation { get; set; }

        [NameInMap("btns")]
        [Validation(Required=false)]
        public List<SendServiceGroupMessageRequestBtns> Btns { get; set; }
        public class SendServiceGroupMessageRequestBtns : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.dingtalk.com">http://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("actionURL")]
            [Validation(Required=false)]
            public string ActionURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试按钮</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你有新的任务待审批</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasContentLinks")]
        [Validation(Required=false)]
        public bool? HasContentLinks { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isAtAll")]
        [Validation(Required=false)]
        public bool? IsAtAll { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKDOWN</para>
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        [NameInMap("receiverDingtalkIds")]
        [Validation(Required=false)]
        public List<string> ReceiverDingtalkIds { get; set; }

        [NameInMap("receiverMobiles")]
        [Validation(Required=false)]
        public List<string> ReceiverMobiles { get; set; }

        [NameInMap("receiverUnionIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidxxxxx==</para>
        /// </summary>
        [NameInMap("targetOpenConversationId")]
        [Validation(Required=false)]
        public string TargetOpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>服务提醒</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
