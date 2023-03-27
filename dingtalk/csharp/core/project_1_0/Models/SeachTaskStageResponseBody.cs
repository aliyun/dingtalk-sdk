// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SeachTaskStageResponseBody : TeaModel {
        /// <summary>
        /// 分页标，供分页使用，下一页token。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 任务列表列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SeachTaskStageResponseBodyResult> Result { get; set; }
        public class SeachTaskStageResponseBodyResult : TeaModel {
            /// <summary>
            /// 创建时间。
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 创建者用户 ID。
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 任务列表名称。
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 任务列表名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 项目 ID。
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// 任务分组 ID。
            /// </summary>
            [NameInMap("taskListId")]
            [Validation(Required=false)]
            public string TaskListId { get; set; }

            /// <summary>
            /// 任务列表 ID。
            /// </summary>
            [NameInMap("taskStageId")]
            [Validation(Required=false)]
            public string TaskStageId { get; set; }

            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

        /// <summary>
        /// 总数。
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
