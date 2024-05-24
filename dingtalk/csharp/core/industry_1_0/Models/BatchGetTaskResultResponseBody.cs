// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class BatchGetTaskResultResponseBody : TeaModel {
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<BatchGetTaskResultResponseBodyTasks> Tasks { get; set; }
        public class BatchGetTaskResultResponseBodyTasks : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public BatchGetTaskResultResponseBodyTasksResult Result { get; set; }
            public class BatchGetTaskResultResponseBodyTasksResult : TeaModel {
                [NameInMap("audioText")]
                [Validation(Required=false)]
                public string AudioText { get; set; }

                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("items")]
                [Validation(Required=false)]
                public List<BatchGetTaskResultResponseBodyTasksResultItems> Items { get; set; }
                public class BatchGetTaskResultResponseBodyTasksResultItems : TeaModel {
                    [NameInMap("info")]
                    [Validation(Required=false)]
                    public string Info { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("point")]
                    [Validation(Required=false)]
                    public long? Point { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
