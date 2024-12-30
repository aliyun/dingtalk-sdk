// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractReviewTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateContractReviewTaskResponseBodyResult Result { get; set; }
        public class CreateContractReviewTaskResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public CreateContractReviewTaskResponseBodyResultData Data { get; set; }
            public class CreateContractReviewTaskResponseBodyResultData : TeaModel {
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
