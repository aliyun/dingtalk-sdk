// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetTaskByIdsRequest : TeaModel {
        /// <summary>
        /// 父任务ID,和taskIds冲突(选其一)。
        /// </summary>
        [NameInMap("parentTaskId")]
        [Validation(Required=false)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// 任务ID集合,使用逗号分隔,和parentTaskId冲突(选其一)。
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
