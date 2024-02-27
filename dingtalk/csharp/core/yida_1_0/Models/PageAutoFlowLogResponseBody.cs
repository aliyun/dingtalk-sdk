// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class PageAutoFlowLogResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<PageAutoFlowLogResponseBodyData> Data { get; set; }
        public class PageAutoFlowLogResponseBodyData : TeaModel {
            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("elapsedTimeGMT")]
            [Validation(Required=false)]
            public long? ElapsedTimeGMT { get; set; }

            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            [NameInMap("procInstanceId")]
            [Validation(Required=false)]
            public string ProcInstanceId { get; set; }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("srcProcInstanceFinishTimeGMT")]
            [Validation(Required=false)]
            public string SrcProcInstanceFinishTimeGMT { get; set; }

            [NameInMap("srcProcInstanceId")]
            [Validation(Required=false)]
            public string SrcProcInstanceId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("hasMoreData")]
        [Validation(Required=false)]
        public bool? HasMoreData { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
