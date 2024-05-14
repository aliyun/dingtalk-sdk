// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class UpdateInteractiveOTOMessageRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public UpdateInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class UpdateInteractiveOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            [NameInMap("cardData")]
            [Validation(Required=false)]
            public string CardData { get; set; }

            [NameInMap("updateOptions")]
            [Validation(Required=false)]
            public UpdateInteractiveOTOMessageRequestDetailUpdateOptions UpdateOptions { get; set; }
            public class UpdateInteractiveOTOMessageRequestDetailUpdateOptions : TeaModel {
                [NameInMap("updateCardDataByKey")]
                [Validation(Required=false)]
                public bool? UpdateCardDataByKey { get; set; }

                [NameInMap("updatePrivateDataByKey")]
                [Validation(Required=false)]
                public bool? UpdatePrivateDataByKey { get; set; }

            }

            [NameInMap("userIdPrivateDataMap")]
            [Validation(Required=false)]
            public string UserIdPrivateDataMap { get; set; }

        }

    }

}
