// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class ConfirmContractReviewResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ConfirmContractReviewResponseBodyData Data { get; set; }
        public class ConfirmContractReviewResponseBodyData : TeaModel {
            [NameInMap("recommended")]
            [Validation(Required=false)]
            public ConfirmContractReviewResponseBodyDataRecommended Recommended { get; set; }
            public class ConfirmContractReviewResponseBodyDataRecommended : TeaModel {
                [NameInMap("contract_type")]
                [Validation(Required=false)]
                public string ContractType { get; set; }

                [NameInMap("scale")]
                [Validation(Required=false)]
                public string Scale { get; set; }

                [NameInMap("standpoint")]
                [Validation(Required=false)]
                public string Standpoint { get; set; }

            }

            [NameInMap("review_id")]
            [Validation(Required=false)]
            public string ReviewId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
