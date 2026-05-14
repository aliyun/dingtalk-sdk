// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class CreateAsrTranscriptionResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAsrTranscriptionResponseBodyResult Result { get; set; }
        public class CreateAsrTranscriptionResponseBodyResult : TeaModel {
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
