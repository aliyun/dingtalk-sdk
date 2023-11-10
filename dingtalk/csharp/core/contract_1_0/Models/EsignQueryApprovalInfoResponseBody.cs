// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignQueryApprovalInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EsignQueryApprovalInfoResponseBodyResult Result { get; set; }
        public class EsignQueryApprovalInfoResponseBodyResult : TeaModel {
            [NameInMap("bpmsProcessBusinessId")]
            [Validation(Required=false)]
            public string BpmsProcessBusinessId { get; set; }

            [NameInMap("bpmsProcessInstanceId")]
            [Validation(Required=false)]
            public string BpmsProcessInstanceId { get; set; }

            [NameInMap("bpmsProcessInstanceUrl")]
            [Validation(Required=false)]
            public string BpmsProcessInstanceUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
