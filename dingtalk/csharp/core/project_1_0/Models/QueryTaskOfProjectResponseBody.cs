// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class QueryTaskOfProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f279e812-e431-428d-846d-cxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryTaskOfProjectResponseBodyResult> Result { get; set; }
        public class QueryTaskOfProjectResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("accomplished")]
            [Validation(Required=false)]
            public string Accomplished { get; set; }

            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>标题2</para>
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
            /// <para>62c25e3bba7ce40xxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<QueryTaskOfProjectResponseBodyResultCustomfields> Customfields { get; set; }
            public class QueryTaskOfProjectResponseBodyResultCustomfields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>62c25e3bbxx0xxx</para>
                /// </summary>
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

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
            /// <para>62cxxxxxxx</para>
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>备注</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3bbaxxxxx</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3bbxx0xxx</para>
            /// </summary>
            [NameInMap("scenariofieldconfigId")]
            [Validation(Required=false)]
            public string ScenariofieldconfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3bbxx0xxx</para>
            /// </summary>
            [NameInMap("sprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3bbxx0xxx</para>
            /// </summary>
            [NameInMap("stageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("storyPoint")]
            [Validation(Required=false)]
            public int? StoryPoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3bbxx0xxx</para>
            /// </summary>
            [NameInMap("tagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3bbaxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3bbxx0xxx</para>
            /// </summary>
            [NameInMap("taskflowstatusId")]
            [Validation(Required=false)]
            public string TaskflowstatusId { get; set; }

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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
