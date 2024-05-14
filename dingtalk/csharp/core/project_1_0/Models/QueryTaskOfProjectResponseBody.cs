// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class QueryTaskOfProjectResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryTaskOfProjectResponseBodyResult> Result { get; set; }
        public class QueryTaskOfProjectResponseBodyResult : TeaModel {
            [NameInMap("accomplished")]
            [Validation(Required=false)]
            public string Accomplished { get; set; }

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
            public List<QueryTaskOfProjectResponseBodyResultCustomfields> Customfields { get; set; }
            public class QueryTaskOfProjectResponseBodyResultCustomfields : TeaModel {
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

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

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("scenariofieldconfigId")]
            [Validation(Required=false)]
            public string ScenariofieldconfigId { get; set; }

            [NameInMap("sprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }

            [NameInMap("stageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("storyPoint")]
            [Validation(Required=false)]
            public int? StoryPoint { get; set; }

            [NameInMap("tagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskflowstatusId")]
            [Validation(Required=false)]
            public string TaskflowstatusId { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
