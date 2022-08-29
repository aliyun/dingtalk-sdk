// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryIntegratedTodoTaskResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("taskPage")]
        [Validation(Required=false)]
        public QueryIntegratedTodoTaskResponseBodyTaskPage TaskPage { get; set; }
        public class QueryIntegratedTodoTaskResponseBodyTaskPage : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryIntegratedTodoTaskResponseBodyTaskPageList> List { get; set; }
            public class QueryIntegratedTodoTaskResponseBodyTaskPageList : TeaModel {
                public string ActivityId { get; set; }
                public long? CreateTime { get; set; }
                public string FinishTime { get; set; }
                public string ProcessInstanceId { get; set; }
                public string Result { get; set; }
                public string Status { get; set; }
                public long? TaskId { get; set; }
                public string UserId { get; set; }
            }
        };

    }

}
