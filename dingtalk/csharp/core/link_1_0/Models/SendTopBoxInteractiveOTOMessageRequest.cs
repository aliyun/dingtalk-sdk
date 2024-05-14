// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendTopBoxInteractiveOTOMessageRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendTopBoxInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class SendTopBoxInteractiveOTOMessageRequestDetail : TeaModel {
            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("expiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userIdPrivateDataMap")]
            [Validation(Required=false)]
            public Dictionary<string, DetailUserIdPrivateDataMapValue> UserIdPrivateDataMap { get; set; }

        }

    }

}
