// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetServiceChapterSummaryResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetServiceChapterSummaryResponseBodyResult> Result { get; set; }
        public class GetServiceChapterSummaryResponseBodyResult : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
