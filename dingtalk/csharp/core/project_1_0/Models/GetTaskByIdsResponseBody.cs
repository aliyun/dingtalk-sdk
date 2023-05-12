// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetTaskByIdsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetTaskByIdsResponseBodyResult> Result { get; set; }
        public class GetTaskByIdsResponseBodyResult : TeaModel {
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

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<GetTaskByIdsResponseBodyResultCustomFields> CustomFields { get; set; }
            public class GetTaskByIdsResponseBodyResultCustomFields : TeaModel {
                [NameInMap("customFieldId")]
                [Validation(Required=false)]
                public string CustomFieldId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<GetTaskByIdsResponseBodyResultCustomFieldsValue> Value { get; set; }
                public class GetTaskByIdsResponseBodyResultCustomFieldsValue : TeaModel {
                    [NameInMap("customFieldValueId")]
                    [Validation(Required=false)]
                    public string CustomFieldValueId { get; set; }

                    [NameInMap("metaString")]
                    [Validation(Required=false)]
                    public string MetaString { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

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

            [NameInMap("scenarioFieldConfigId")]
            [Validation(Required=false)]
            public string ScenarioFieldConfigId { get; set; }

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

            [NameInMap("taskStageId")]
            [Validation(Required=false)]
            public string TaskStageId { get; set; }

            [NameInMap("taskflowStatusId")]
            [Validation(Required=false)]
            public string TaskflowStatusId { get; set; }

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

    }

}
