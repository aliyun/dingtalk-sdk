// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractReviewResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateContractReviewResponseBodyResult Result { get; set; }
        public class CreateContractReviewResponseBodyResult : TeaModel {
            [NameInMap("planFinishTime")]
            [Validation(Required=false)]
            public long? PlanFinishTime { get; set; }

            [NameInMap("reviewType")]
            [Validation(Required=false)]
            public string ReviewType { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
