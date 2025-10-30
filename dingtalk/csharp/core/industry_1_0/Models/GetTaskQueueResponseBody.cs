// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class GetTaskQueueResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTaskQueueResponseBodyResult Result { get; set; }
        public class GetTaskQueueResponseBodyResult : TeaModel {
            [NameInMap("pendingCount")]
            [Validation(Required=false)]
            public int? PendingCount { get; set; }

            [NameInMap("processingCount")]
            [Validation(Required=false)]
            public int? ProcessingCount { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
