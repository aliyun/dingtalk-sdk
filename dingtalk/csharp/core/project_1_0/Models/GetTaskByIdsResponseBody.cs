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
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("accomplishTime")]
            [Validation(Required=false)]
            public string AccomplishTime { get; set; }

            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>任务标题</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0517xxxxxxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<GetTaskByIdsResponseBodyResultCustomFields> CustomFields { get; set; }
            public class GetTaskByIdsResponseBodyResultCustomFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>61122xxxxxxxx</para>
                /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6722223xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("customFieldValueId")]
                    [Validation(Required=false)]
                    public string CustomFieldValueId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>拓展数据</para>
                    /// </summary>
                    [NameInMap("metaString")]
                    [Validation(Required=false)]
                    public string MetaString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>自定义字段1</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0517xxxxxxx</para>
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>任务备注</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60a2187eb72xxxxxxx</para>
            /// </summary>
            [NameInMap("parentTaskId")]
            [Validation(Required=false)]
            public string ParentTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3b376ecxxxxxxx</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("recurrence")]
            [Validation(Required=false)]
            public List<string> Recurrence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6922xxxxxxxx</para>
            /// </summary>
            [NameInMap("scenarioFieldConfigId")]
            [Validation(Required=false)]
            public string ScenarioFieldConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>61922xxxxxxxx</para>
            /// </summary>
            [NameInMap("sprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("storyPoint")]
            [Validation(Required=false)]
            public string StoryPoint { get; set; }

            [NameInMap("tagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60a2187eb72xxxxxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6922xxxxxxxx</para>
            /// </summary>
            [NameInMap("taskListId")]
            [Validation(Required=false)]
            public string TaskListId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6622134xxxxxx</para>
            /// </summary>
            [NameInMap("taskStageId")]
            [Validation(Required=false)]
            public string TaskStageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6722xxxxxxxx</para>
            /// </summary>
            [NameInMap("taskflowStatusId")]
            [Validation(Required=false)]
            public string TaskflowStatusId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("uniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>member</para>
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

    }

}
