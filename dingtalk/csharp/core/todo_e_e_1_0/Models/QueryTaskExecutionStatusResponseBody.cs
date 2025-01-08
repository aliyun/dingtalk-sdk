// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class QueryTaskExecutionStatusResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryTaskExecutionStatusResponseBodyData> Data { get; set; }
        public class QueryTaskExecutionStatusResponseBodyData : TeaModel {
            [NameInMap("done")]
            [Validation(Required=false)]
            public bool? Done { get; set; }

            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("finishDate")]
            [Validation(Required=false)]
            public long? FinishDate { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
