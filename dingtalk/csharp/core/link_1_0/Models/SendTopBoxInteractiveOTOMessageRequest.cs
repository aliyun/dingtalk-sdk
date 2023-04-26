// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendTopBoxInteractiveOTOMessageRequest : TeaModel {
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendTopBoxInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class SendTopBoxInteractiveOTOMessageRequestDetail : TeaModel {
            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            [NameInMap("cardData")]
            [Validation(Required=false)]
            public SendTopBoxInteractiveOTOMessageRequestDetailCardData CardData { get; set; }
            public class SendTopBoxInteractiveOTOMessageRequestDetailCardData : TeaModel {
                [NameInMap("cardMediaIdParamMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> CardMediaIdParamMap { get; set; }

                [NameInMap("cardParamMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> CardParamMap { get; set; }

            }

            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            [NameInMap("expiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userIdPrivateDataMap")]
            [Validation(Required=false)]
            public Dictionary<string, DetailUserIdPrivateDataMapValue> UserIdPrivateDataMap { get; set; }

        }

    }

}
