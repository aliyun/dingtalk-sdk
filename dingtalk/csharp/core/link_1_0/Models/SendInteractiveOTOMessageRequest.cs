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
            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            [NameInMap("cardData")]
            [Validation(Required=false)]
            public string CardData { get; set; }

            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            /// <summary>
            /// 消息接收人id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userIdPrivateDataMap")]
            [Validation(Required=false)]
            public string UserIdPrivateDataMap { get; set; }

        }

    }

}
