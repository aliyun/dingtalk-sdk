// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class GetContractReviewBenefitResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetContractReviewBenefitResponseBodyResult Result { get; set; }
        public class GetContractReviewBenefitResponseBodyResult : TeaModel {
            [NameInMap("benefitResponses")]
            [Validation(Required=false)]
            public List<GetContractReviewBenefitResponseBodyResultBenefitResponses> BenefitResponses { get; set; }
            public class GetContractReviewBenefitResponseBodyResultBenefitResponses : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("restBenefit")]
                [Validation(Required=false)]
                public long? RestBenefit { get; set; }

                [NameInMap("usedBenefit")]
                [Validation(Required=false)]
                public long? UsedBenefit { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
