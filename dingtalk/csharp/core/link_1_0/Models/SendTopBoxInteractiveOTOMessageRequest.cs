// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendTopBoxInteractiveOTOMessageRequest : TeaModel {
        /// <summary>
        /// 卡片信息
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendTopBoxInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class SendTopBoxInteractiveOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// 卡片回调 URL 地址，不填则无回调
            /// </summary>
            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// 唯一标识一张卡片的ID，卡片幂等ID
            /// </summary>
            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            /// <summary>
            /// 卡片数据
            /// </summary>
            [NameInMap("cardData")]
            [Validation(Required=false)]
            public SendTopBoxInteractiveOTOMessageRequestDetailCardData CardData { get; set; }
            public class SendTopBoxInteractiveOTOMessageRequestDetailCardData : TeaModel {
                /// <summary>
                /// 富媒体卡片数据
                /// </summary>
                [NameInMap("cardMediaIdParamMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> CardMediaIdParamMap { get; set; }

                /// <summary>
                /// 普通文本卡片数据
                /// </summary>
                [NameInMap("cardParamMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> CardParamMap { get; set; }

            }

            /// <summary>
            /// 卡片模板 ID
            /// </summary>
            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            /// <summary>
            /// 失效时间，时间戳（毫秒），最长时间不超过 90 天
            /// </summary>
            [NameInMap("expiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// 接收人 userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 卡片用户差异化数据
            /// </summary>
            [NameInMap("userIdPrivateDataMap")]
            [Validation(Required=false)]
            public Dictionary<string, DetailUserIdPrivateDataMapValue> UserIdPrivateDataMap { get; set; }

        }

    }

}
