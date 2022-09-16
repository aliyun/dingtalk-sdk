// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class RedirectWorkflowTaskRequest : TeaModel {
        /// <summary>
        /// 操作节点名
        /// </summary>
        [NameInMap("actionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// 操作人的用户ID，需要跟任务的当前执行人保持一致，否则无法通过校验
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 转交备注信息
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// OA审批任务ID
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// OA审批任务被转交对象的用户ID
        /// </summary>
        [NameInMap("toUserId")]
        [Validation(Required=false)]
        public string ToUserId { get; set; }

    }

}
