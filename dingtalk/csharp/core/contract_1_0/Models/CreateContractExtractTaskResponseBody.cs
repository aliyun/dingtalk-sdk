// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractExtractTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateContractExtractTaskResponseBodyResult Result { get; set; }
        public class CreateContractExtractTaskResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public CreateContractExtractTaskResponseBodyResultData Data { get; set; }
            public class CreateContractExtractTaskResponseBodyResultData : TeaModel {
                [NameInMap("extractTaskId")]
                [Validation(Required=false)]
                public string ExtractTaskId { get; set; }

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
