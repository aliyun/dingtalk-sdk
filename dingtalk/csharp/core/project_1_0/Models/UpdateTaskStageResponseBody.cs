// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskStageResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateTaskStageResponseBodyResult Result { get; set; }
        public class UpdateTaskStageResponseBodyResult : TeaModel {
            /// <summary>
            /// 任务完成时间(UTC)。
            /// </summary>
            [NameInMap("accomplishTime")]
            [Validation(Required=false)]
            public string AccomplishTime { get; set; }

            /// <summary>
            /// 是否任务已完成。
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// 项目ID。
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// 任务列ID。
            /// </summary>
            [NameInMap("stageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            /// <summary>
            /// 任务ID。
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// 任务分组ID。
            /// </summary>
            [NameInMap("taskListId")]
            [Validation(Required=false)]
            public string TaskListId { get; set; }

            /// <summary>
            /// 更新时间(UTC)。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
