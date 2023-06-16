// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetPointActionRecordResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetPointActionRecordResponseBodyResult Result { get; set; }
        public class GetPointActionRecordResponseBodyResult : TeaModel {
            [NameInMap("actionTime")]
            [Validation(Required=false)]
            public string ActionTime { get; set; }

            [NameInMap("quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
