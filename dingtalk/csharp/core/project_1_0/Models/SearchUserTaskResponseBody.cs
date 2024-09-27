// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchUserTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DXF1ZXJ5QW5kRmV0Y2gBAAAAAAbMXT4WVjNKbUstaldRX3lOOHNBbElzcjA5Zw==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F86698E9-E4F5-1231-AC99-2ECFC0D37BDE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchUserTaskResponseBodyResult> Result { get; set; }
        public class SearchUserTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-12T03:39:54.918Z</para>
            /// </summary>
            [NameInMap("accomplishTime")]
            [Validation(Required=false)]
            public string AccomplishTime { get; set; }

            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>任务内容</para>
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
            /// <para>63a9207a042f7c254f60519c</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<SearchUserTaskResponseBodyResultCustomFields> CustomFields { get; set; }
            public class SearchUserTaskResponseBodyResultCustomFields : TeaModel {
                [NameInMap("customFieldId")]
                [Validation(Required=false)]
                public string CustomFieldId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>number</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<SearchUserTaskResponseBodyResultCustomFieldsValue> Value { get; set; }
                public class SearchUserTaskResponseBodyResultCustomFieldsValue : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>642fb16c4a622b2e3184229c</para>
                    /// </summary>
                    [NameInMap("customFieldValueId")]
                    [Validation(Required=false)]
                    public string CustomFieldValueId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>元数据内容</para>
                    /// </summary>
                    [NameInMap("metaString")]
                    [Validation(Required=false)]
                    public string MetaString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>标题</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-05T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>63a9207a042f7c254f60519c</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>备注内容</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>644b6f4cca369863fbc8abbb</para>
            /// </summary>
            [NameInMap("parentTaskId")]
            [Validation(Required=false)]
            public string ParentTaskId { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>643394f81502a928dbd5ba37</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("recurrence")]
            [Validation(Required=false)]
            public List<string> Recurrence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64099d5b2f404400174d7fc1</para>
            /// </summary>
            [NameInMap("scenarioFieldConfigId")]
            [Validation(Required=false)]
            public string ScenarioFieldConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64099d5b2f404400174d7fc1</para>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("storyPoint")]
            [Validation(Required=false)]
            public string StoryPoint { get; set; }

            [NameInMap("tagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>642befe827feb683f91bd529</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6436278ea14fe435351668a2</para>
            /// </summary>
            [NameInMap("taskListId")]
            [Validation(Required=false)]
            public string TaskListId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6436278ea14fe435351668a4</para>
            /// </summary>
            [NameInMap("taskStageId")]
            [Validation(Required=false)]
            public string TaskStageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64099d5b2f404400174d7fbb</para>
            /// </summary>
            [NameInMap("taskflowStatusId")]
            [Validation(Required=false)]
            public string TaskflowStatusId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
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
            /// <para>projectMembers</para>
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

    }

}
