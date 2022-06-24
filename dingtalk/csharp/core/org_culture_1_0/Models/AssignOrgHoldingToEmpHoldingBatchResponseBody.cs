// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class AssignOrgHoldingToEmpHoldingBatchResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AssignOrgHoldingToEmpHoldingBatchResponseBodyResult Result { get; set; }
        public class AssignOrgHoldingToEmpHoldingBatchResponseBodyResult : TeaModel {
            [NameInMap("openPointInvokeResultDTOS")]
            [Validation(Required=false)]
            public List<AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS> OpenPointInvokeResultDTOS { get; set; }
            public class AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS : TeaModel {
                public string Code { get; set; }
                public string InvokeStatus { get; set; }
                public string Msg { get; set; }
                public string OutId { get; set; }
                public string UserId { get; set; }
            }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
