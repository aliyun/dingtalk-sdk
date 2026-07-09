// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QuerySignFlowDetailRequest : TeaModel {
        [NameInMap("bizFlowId")]
        [Validation(Required=false)]
        public string BizFlowId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("signFlowId")]
        [Validation(Required=false)]
        public string SignFlowId { get; set; }

    }

}
