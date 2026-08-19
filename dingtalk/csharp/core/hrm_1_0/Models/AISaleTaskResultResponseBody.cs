// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleTaskResultResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public AISaleTaskResultResponseBodyResult Result { get; set; }
        public class AISaleTaskResultResponseBodyResult : TeaModel {
            [NameInMap("taskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
