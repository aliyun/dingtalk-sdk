// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmeeting_1_0.Models
{
    public class GetTaskFromShanhuiDocResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTaskFromShanhuiDocResponseBodyResult Result { get; set; }
        public class GetTaskFromShanhuiDocResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetTaskFromShanhuiDocResponseBodyResultItems> Items { get; set; }
            public class GetTaskFromShanhuiDocResponseBodyResultItems : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("deadline")]
                [Validation(Required=false)]
                public long? Deadline { get; set; }

                [NameInMap("deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                [NameInMap("executorList")]
                [Validation(Required=false)]
                public List<GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList> ExecutorList { get; set; }
                public class GetTaskFromShanhuiDocResponseBodyResultItemsExecutorList : TeaModel {
                    [NameInMap("executorId")]
                    [Validation(Required=false)]
                    public string ExecutorId { get; set; }

                    [NameInMap("statusStage")]
                    [Validation(Required=false)]
                    public int? StatusStage { get; set; }

                    [NameInMap("subTaskKey")]
                    [Validation(Required=false)]
                    public string SubTaskKey { get; set; }

                }

                [NameInMap("priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                [NameInMap("taskKey")]
                [Validation(Required=false)]
                public string TaskKey { get; set; }

                [NameInMap("taskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                [NameInMap("taskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
