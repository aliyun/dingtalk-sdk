// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetTranscriptSummaryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTranscriptSummaryResponseBodyResult Result { get; set; }
        public class GetTranscriptSummaryResponseBodyResult : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

    }

}
