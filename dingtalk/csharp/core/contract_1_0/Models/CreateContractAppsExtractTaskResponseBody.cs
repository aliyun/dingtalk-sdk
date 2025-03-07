// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractAppsExtractTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateContractAppsExtractTaskResponseBodyResult Result { get; set; }
        public class CreateContractAppsExtractTaskResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public CreateContractAppsExtractTaskResponseBodyResultData Data { get; set; }
            public class CreateContractAppsExtractTaskResponseBodyResultData : TeaModel {
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
