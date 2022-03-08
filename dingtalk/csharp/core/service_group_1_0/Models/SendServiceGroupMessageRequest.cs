// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendServiceGroupMessageRequest : TeaModel {
        /// <summary>
        /// at dingtalkId
        /// </summary>
        [NameInMap("atDingtalkIds")]
        [Validation(Required=false)]
        public List<string> AtDingtalkIds { get; set; }

        /// <summary>
        /// at 手机号
        /// </summary>
        [NameInMap("atMobiles")]
        [Validation(Required=false)]
        public List<string> AtMobiles { get; set; }

        /// <summary>
        /// at unionIds
        /// </summary>
        [NameInMap("atUnionIds")]
        [Validation(Required=false)]
        public List<string> AtUnionIds { get; set; }

        /// <summary>
        /// 排列方式：0-按钮竖直排列，1-按钮横向排列
        /// </summary>
        [NameInMap("btnOrientation")]
        [Validation(Required=false)]
        public string BtnOrientation { get; set; }

        /// <summary>
        /// actionCard按钮
        /// </summary>
        [NameInMap("btns")]
        [Validation(Required=false)]
        public List<SendServiceGroupMessageRequestBtns> Btns { get; set; }
        public class SendServiceGroupMessageRequestBtns : TeaModel {
            /// <summary>
            /// 跳转地址
            /// </summary>
            [NameInMap("actionURL")]
            [Validation(Required=false)]
            public string ActionURL { get; set; }

            /// <summary>
            /// 按钮名称
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 如果正文内容包含链接，并且按钮链接和文本链接分开跳转，则传递true; 否则传递false
        /// </summary>
        [NameInMap("hasContentLinks")]
        [Validation(Required=false)]
        public bool? HasContentLinks { get; set; }

        /// <summary>
        /// 是否 at所有人
        /// </summary>
        [NameInMap("isAtAll")]
        [Validation(Required=false)]
        public bool? IsAtAll { get; set; }

        /// <summary>
        /// 消息类型：MARKDOWN，ACTIONCARD
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// dingtalkId接收者
        /// </summary>
        [NameInMap("receiverDingtalkIds")]
        [Validation(Required=false)]
        public List<string> ReceiverDingtalkIds { get; set; }

        /// <summary>
        /// 手机号接收者
        /// </summary>
        [NameInMap("receiverMobiles")]
        [Validation(Required=false)]
        public List<string> ReceiverMobiles { get; set; }

        /// <summary>
        /// unionId接收者
        /// </summary>
        [NameInMap("receiverUnionIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIds { get; set; }

        /// <summary>
        /// 开放群ID
        /// </summary>
        [NameInMap("targetOpenConversationId")]
        [Validation(Required=false)]
        public string TargetOpenConversationId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
