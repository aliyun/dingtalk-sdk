// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractCompareTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateContractCompareTaskResponseBodyResult Result { get; set; }
        public class CreateContractCompareTaskResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public CreateContractCompareTaskResponseBodyResultData Data { get; set; }
            public class CreateContractCompareTaskResponseBodyResultData : TeaModel {
                [NameInMap("compareTaskId")]
                [Validation(Required=false)]
                public string CompareTaskId { get; set; }

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
