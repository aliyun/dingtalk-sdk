// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumBatchExecuteProcessInstancesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, ResultValue> Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
