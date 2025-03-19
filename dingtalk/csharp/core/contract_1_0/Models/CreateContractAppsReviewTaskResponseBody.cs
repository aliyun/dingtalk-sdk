// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractAppsReviewTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateContractAppsReviewTaskResponseBodyResult Result { get; set; }
        public class CreateContractAppsReviewTaskResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public CreateContractAppsReviewTaskResponseBodyResultData Data { get; set; }
            public class CreateContractAppsReviewTaskResponseBodyResultData : TeaModel {
                [NameInMap("reviewTaskId")]
                [Validation(Required=false)]
                public string ReviewTaskId { get; set; }

            }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
