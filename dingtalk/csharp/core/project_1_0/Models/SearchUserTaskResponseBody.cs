// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchUserTaskResponseBody : TeaModel {
        /// <summary>
        /// 任务详情集合。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchUserTaskResponseBodyResult> Result { get; set; }
        public class SearchUserTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// 任务完成时间(UTC)。
            /// </summary>
            [NameInMap("accomplishTime")]
            [Validation(Required=false)]
            public string AccomplishTime { get; set; }

            /// <summary>
            /// 祖先任务ID列表。
            /// </summary>
            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }

            /// <summary>
            /// 任务标题。
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 创建时间(UTC)。
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 创建人ID。
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 自定义字段值集合。
            /// </summary>
            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<SearchUserTaskResponseBodyResultCustomfields> Customfields { get; set; }
            public class SearchUserTaskResponseBodyResultCustomfields : TeaModel {
                /// <summary>
                /// 自定义字段ID。
                /// </summary>
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

                /// <summary>
                /// 自定义字段类型。
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// 字段值集合。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public List<SearchUserTaskResponseBodyResultCustomfieldsValue> Value { get; set; }
                public class SearchUserTaskResponseBodyResultCustomfieldsValue : TeaModel {
                    /// <summary>
                    /// 字段值ID。
                    /// </summary>
                    [NameInMap("fieldvalueId")]
                    [Validation(Required=false)]
                    public string FieldvalueId { get; set; }

                    /// <summary>
                    /// 字段值元属性。
                    /// </summary>
                    [NameInMap("metaString")]
                    [Validation(Required=false)]
                    public string MetaString { get; set; }

                    /// <summary>
                    /// 字段值内容。
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// 任务截止时间(UTC)。
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            /// <summary>
            /// 执行人ID。
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// 参与者ID集合。
            /// </summary>
            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            /// <summary>
            /// 是否任务放入回收站。
            /// </summary>
            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            /// <summary>
            /// 是否任务已完成。
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// 任务备注。
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// 父任务ID。
            /// </summary>
            [NameInMap("parentTaskId")]
            [Validation(Required=false)]
            public string ParentTaskId { get; set; }

            /// <summary>
            /// 任务优先级。
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// 项目ID。
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// 重复规则列表。
            /// </summary>
            [NameInMap("recurrence")]
            [Validation(Required=false)]
            public List<string> Recurrence { get; set; }

            /// <summary>
            /// 任务类型ID。
            /// </summary>
            [NameInMap("scenariofieldconfigId")]
            [Validation(Required=false)]
            public string ScenariofieldconfigId { get; set; }

            /// <summary>
            /// 迭代ID。
            /// </summary>
            [NameInMap("sprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }

            /// <summary>
            /// 任务列ID。
            /// </summary>
            [NameInMap("stageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            /// <summary>
            /// 任务开始时间(UTC)。
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// StoryPoint。
            /// </summary>
            [NameInMap("storyPoint")]
            [Validation(Required=false)]
            public string StoryPoint { get; set; }

            /// <summary>
            /// 标签ID集合。
            /// </summary>
            [NameInMap("tagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// 任务状态ID。
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// 任务列表ID。
            /// </summary>
            [NameInMap("taskListId")]
            [Validation(Required=false)]
            public string TaskListId { get; set; }

            /// <summary>
            /// 任务数字ID。
            /// </summary>
            [NameInMap("uniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

            /// <summary>
            /// 更新时间(UTC)。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// 任务隐私性，'involves'表达仅参与者可见; 'members'表达项目成员可见。
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

    }

}
