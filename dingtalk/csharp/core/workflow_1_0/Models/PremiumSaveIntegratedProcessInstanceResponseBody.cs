// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumSaveIntegratedProcessInstanceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumSaveIntegratedProcessInstanceResponseBodyResult Result { get; set; }
        public class PremiumSaveIntegratedProcessInstanceResponseBodyResult : TeaModel {
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

        }

    }

}
