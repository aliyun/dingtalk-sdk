// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendServiceGroupMessageRequest : TeaModel {
        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

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

        /// <summary>
        /// 内容
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// at 手机号
        /// </summary>
        [NameInMap("atMobiles")]
        [Validation(Required=false)]
        public List<string> AtMobiles { get; set; }

        /// <summary>
        /// at dingtalkId
        /// </summary>
        [NameInMap("atDingtalkIds")]
        [Validation(Required=false)]
        public List<string> AtDingtalkIds { get; set; }

        /// <summary>
        /// at unionIds
        /// </summary>
        [NameInMap("atUnionIds")]
        [Validation(Required=false)]
        public List<string> AtUnionIds { get; set; }

        /// <summary>
        /// 手机号接收者
        /// </summary>
        [NameInMap("receiverMobiles")]
        [Validation(Required=false)]
        public List<string> ReceiverMobiles { get; set; }

        /// <summary>
        /// dingtalkId接收者
        /// </summary>
        [NameInMap("receiverDingtalkIds")]
        [Validation(Required=false)]
        public List<string> ReceiverDingtalkIds { get; set; }

        /// <summary>
        /// unionId接收者
        /// </summary>
        [NameInMap("receiverUnionIds")]
        [Validation(Required=false)]
        public List<string> ReceiverUnionIds { get; set; }

        /// <summary>
        /// 消息类型：MARKDOWN，ACTIONCARD
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

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

    }

}
