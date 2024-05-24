// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class TodoTasksResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public TodoTasksResponseBodyResult Result { get; set; }
        public class TodoTasksResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<TodoTasksResponseBodyResultList> List { get; set; }
            public class TodoTasksResponseBodyResultList : TeaModel {
                [NameInMap("businessId")]
                [Validation(Required=false)]
                public string BusinessId { get; set; }

                [NameInMap("canRedirect")]
                [Validation(Required=false)]
                public bool? CanRedirect { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("processCode")]
                [Validation(Required=false)]
                public string ProcessCode { get; set; }

                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
