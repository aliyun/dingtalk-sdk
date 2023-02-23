// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchTaskflowStatusResponseBody : TeaModel {
        /// <summary>
        /// 任务工作流状态列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchTaskflowStatusResponseBodyResult> Result { get; set; }
        public class SearchTaskflowStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// 创建时间。
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 创建者ID。
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 是否已删除。
            /// </summary>
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// 是否特定任务角色才能流转该工作流状态。
            /// </summary>
            [NameInMap("isTaskflowstatusruleexector")]
            [Validation(Required=false)]
            public bool? IsTaskflowstatusruleexector { get; set; }

            /// <summary>
            /// 任务工作流状态类型。  start: 开始  end: 结束  unset: 未设置
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// 任务工作流状态名字。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 任务工作流状态位置。
            /// </summary>
            [NameInMap("pos")]
            [Validation(Required=false)]
            public int? Pos { get; set; }

            /// <summary>
            /// 拒绝的工作流状态Id。
            /// </summary>
            [NameInMap("rejectStatusIds")]
            [Validation(Required=false)]
            public List<string> RejectStatusIds { get; set; }

            /// <summary>
            /// 任务工作流ID。
            /// </summary>
            [NameInMap("taskflowId")]
            [Validation(Required=false)]
            public string TaskflowId { get; set; }

            /// <summary>
            /// 任务工作流状态ID。
            /// </summary>
            [NameInMap("taskflowStatusId")]
            [Validation(Required=false)]
            public string TaskflowStatusId { get; set; }

            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
