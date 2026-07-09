// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateSignFlowResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateSignFlowResponseBodyResult Result { get; set; }
        public class CreateSignFlowResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public CreateSignFlowResponseBodyResultData Data { get; set; }
            public class CreateSignFlowResponseBodyResultData : TeaModel {
                [NameInMap("autoStartErrorMsg")]
                [Validation(Required=false)]
                public string AutoStartErrorMsg { get; set; }

                [NameInMap("bizFlowId")]
                [Validation(Required=false)]
                public string BizFlowId { get; set; }

                [NameInMap("initiateUrl")]
                [Validation(Required=false)]
                public string InitiateUrl { get; set; }

                [NameInMap("signFlowId")]
                [Validation(Required=false)]
                public string SignFlowId { get; set; }

                [NameInMap("signFlowStatus")]
                [Validation(Required=false)]
                public string SignFlowStatus { get; set; }

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
