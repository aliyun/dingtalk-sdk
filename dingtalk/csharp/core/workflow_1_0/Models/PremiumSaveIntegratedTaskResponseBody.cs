// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumSaveIntegratedTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<PremiumSaveIntegratedTaskResponseBodyResult> Result { get; set; }
        public class PremiumSaveIntegratedTaskResponseBodyResult : TeaModel {
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
