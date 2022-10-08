// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class QueryTaskOfProjectResponseBody : TeaModel {
        /// <summary>
        /// 供分页使用，下一页token，从当前页结果中获取。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 任务对象列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryTaskOfProjectResponseBodyResult> Result { get; set; }
        public class QueryTaskOfProjectResponseBodyResult : TeaModel {
            /// <summary>
            /// 任务完成时间。
            /// </summary>
            [NameInMap("accomplished")]
            [Validation(Required=false)]
            public string Accomplished { get; set; }

            /// <summary>
            /// 父任务id列表。
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
            /// 创建时间。
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 创建者id。
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 自定义字段id列表。
            /// </summary>
            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<string> Customfields { get; set; }

            /// <summary>
            /// 任务截止时间。
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            /// <summary>
            /// 执行者id。
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// 参与者列表。
            /// </summary>
            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            /// <summary>
            /// 是否归档。
            /// </summary>
            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            /// <summary>
            /// 是否已删除。
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// 任务是否已完成。
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// 任务自定义标识。
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// 备注。
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// 任务优先级。
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// 任务进度。
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// 项目id。
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// 任务类型id。
            /// </summary>
            [NameInMap("scenariofieldconfigId")]
            [Validation(Required=false)]
            public string ScenariofieldconfigId { get; set; }

            /// <summary>
            /// 任务迭代id。
            /// </summary>
            [NameInMap("sprintId")]
            [Validation(Required=false)]
            public string SprintId { get; set; }

            /// <summary>
            /// 任务列表Id。
            /// </summary>
            [NameInMap("stageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            /// <summary>
            /// 任务开始时间。
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// 故事点数。
            /// </summary>
            [NameInMap("storyPoint")]
            [Validation(Required=false)]
            public int? StoryPoint { get; set; }

            /// <summary>
            /// 标签id集合。
            /// </summary>
            [NameInMap("tagIds")]
            [Validation(Required=false)]
            public string TagIds { get; set; }

            /// <summary>
            /// 任务id。
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// 任务状态id。
            /// </summary>
            [NameInMap("taskflowstatusId")]
            [Validation(Required=false)]
            public string TaskflowstatusId { get; set; }

            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// 任务的可见性规则 involves | members。
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

        /// <summary>
        /// 任务总数。
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
