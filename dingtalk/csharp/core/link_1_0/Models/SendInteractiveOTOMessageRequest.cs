// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendInteractiveOTOMessageRequest : TeaModel {
        /// <summary>
        /// 消息详情
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class SendInteractiveOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// 卡片回调的URL地址，不传此参数则无回调。
            /// 回调URL暂不支持query参数。
            /// </summary>
            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// 唯一标识一张卡片的ID，卡片幂等ID，可用于后续卡片更新。
            /// > 该参数由开发者传入，确保唯一。
            /// </summary>
            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            /// <summary>
            /// 卡片模板内容参数，JsonObject结构型。
            /// 卡片数据结构需要与卡片搭建平台上定义的参数结构一致。
            /// </summary>
            [NameInMap("cardData")]
            [Validation(Required=false)]
            public string CardData { get; set; }

            /// <summary>
            /// 卡片搭建平台模板ID，详情可查阅 [创建消息模板](https://open.dingtalk.com/document/group/create-message-template) 。
            /// </summary>
            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            /// <summary>
            /// 消息接收人id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 卡片模板userId差异用户参数，json结构体。
            /// 用户对应的数据结构需要与卡片搭建平台上定义的参数结构一致。
            /// 
            /// </summary>
            [NameInMap("userIdPrivateDataMap")]
            [Validation(Required=false)]
            public string UserIdPrivateDataMap { get; set; }

        }

    }

}
