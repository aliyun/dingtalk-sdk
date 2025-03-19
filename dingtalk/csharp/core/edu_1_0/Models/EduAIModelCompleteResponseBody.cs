// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EduAIModelCompleteResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EduAIModelCompleteResponseBodyResult Result { get; set; }
        public class EduAIModelCompleteResponseBodyResult : TeaModel {
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public Dictionary<string, object> Result { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
