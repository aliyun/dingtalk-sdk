// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class QueryMemoryLearningTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryMemoryLearningTaskResponseBodyResult Result { get; set; }
        public class QueryMemoryLearningTaskResponseBodyResult : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
