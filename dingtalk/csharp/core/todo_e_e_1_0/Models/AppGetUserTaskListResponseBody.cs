// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class AppGetUserTaskListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<AppGetUserTaskListResponseBodyData> Data { get; set; }
        public class AppGetUserTaskListResponseBodyData : TeaModel {
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("done")]
            [Validation(Required=false)]
            public bool? Done { get; set; }

            [NameInMap("dueTime")]
            [Validation(Required=false)]
            public long? DueTime { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

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
