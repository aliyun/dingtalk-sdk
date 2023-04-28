// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchUserTaskResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchUserTaskResponseBodyResult> Result { get; set; }
        public class SearchUserTaskResponseBodyResult : TeaModel {
            [NameInMap("accomplishTime")]
            [Validation(Required=false)]
            public string AccomplishTime { get; set; }

            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<SearchUserTaskResponseBodyResultCustomfields> Customfields { get; set; }
            public class SearchUserTaskResponseBodyResultCustomfields : TeaModel {
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<SearchUserTaskResponseBodyResultCustomfieldsValue> Value { get; set; }
                public class SearchUserTaskResponseBodyResultCustomfieldsValue : TeaModel {
                    [NameInMap("fieldvalueId")]
                    [Validation(Required=false)]
                    public string FieldvalueId { get; set; }

                    [NameInMap("metaString")]
                    [Validation(Required=false)]
                    public string MetaString { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("totalCount")]
                    [Validation(Required=false)]
                    public int? TotalCount { get; set; }

                }

            }

            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            [NameInMap("parentTaskId")]
            [Validation(Required=false)]
            public string ParentTaskId { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("recurrence")]
            [Validation(Required=false)]
            public List<string> Recurrence { get; set; }

            [NameInMap("sfcId")]
            [Validation(Required=false)]
            public string SfcId { get; set; }

            [NameInMap("sprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("storyPoint")]
            [Validation(Required=false)]
            public string StoryPoint { get; set; }

            [NameInMap("tagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskListId")]
            [Validation(Required=false)]
            public string TaskListId { get; set; }

            [NameInMap("taskflowstatusId")]
            [Validation(Required=false)]
            public string TaskflowstatusId { get; set; }

            [NameInMap("taskstageId")]
            [Validation(Required=false)]
            public string TaskstageId { get; set; }

            [NameInMap("uniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

        [NameInMap("totalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
