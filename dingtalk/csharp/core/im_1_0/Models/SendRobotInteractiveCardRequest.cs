// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendRobotInteractiveCardRequest : TeaModel {
        /// <summary>
        /// 可交互卡片回调的url【可空：不填写无需回调】
        /// </summary>
        [NameInMap("callbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
        /// </summary>
        [NameInMap("cardBizId")]
        [Validation(Required=false)]
        public string CardBizId { get; set; }

        /// <summary>
        /// 卡片模板-文本内容参数（卡片json结构体）
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        /// <summary>
        /// 卡片搭建平台模板ID
        /// </summary>
        [NameInMap("cardTemplateId")]
        [Validation(Required=false)]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 【openConversationId & singleChatReceiver 二选一必填】接收卡片的加密群ID，特指多人群会话（非单聊）
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// 互动卡片发送选项
        /// </summary>
        [NameInMap("sendOptions")]
        [Validation(Required=false)]
        public SendRobotInteractiveCardRequestSendOptions SendOptions { get; set; }
        public class SendRobotInteractiveCardRequestSendOptions : TeaModel {
            [NameInMap("atAll")]
            [Validation(Required=false)]
            public bool? AtAll { get; set; }
            [NameInMap("atUserListJson")]
            [Validation(Required=false)]
            public string AtUserListJson { get; set; }
            [NameInMap("cardPropertyJson")]
            [Validation(Required=false)]
            public string CardPropertyJson { get; set; }
            [NameInMap("receiverListJson")]
            [Validation(Required=false)]
            public string ReceiverListJson { get; set; }
        };

        /// <summary>
        /// 【openConversationId & singleChatReceiver 二选一必填】单聊会话接受者json串
        /// </summary>
        [NameInMap("singleChatReceiver")]
        [Validation(Required=false)]
        public string SingleChatReceiver { get; set; }

        /// <summary>
        /// 卡片模板-userId差异用户参数（json结构体）
        /// </summary>
        [NameInMap("unionIdPrivateDataMap")]
        [Validation(Required=false)]
        public string UnionIdPrivateDataMap { get; set; }

        /// <summary>
        /// 卡片模板-userId差异用户参数（json结构体）
        /// </summary>
        [NameInMap("userIdPrivateDataMap")]
        [Validation(Required=false)]
        public string UserIdPrivateDataMap { get; set; }

    }

}
