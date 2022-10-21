// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class UpdateIntegratedTaskRequest : TeaModel {
        /// <summary>
        /// OA审批流程实例ID，过创建实例接口获取
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<UpdateIntegratedTaskRequestTasks> Tasks { get; set; }
        public class UpdateIntegratedTaskRequestTasks : TeaModel {
            /// <summary>
            /// 当status为COMPLETED时，必须指定任务结果：
            /// AGREE：同意
            /// REFUSE：拒绝
            /// 
            /// 说明 当status为CANCELED时，不需要传result。
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// 更新为目标任务状态，可选值 CANCELED、COMPLETED
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// OA审批任务ID
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

    }

}
