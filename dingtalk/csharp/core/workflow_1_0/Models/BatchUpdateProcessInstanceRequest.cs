// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class BatchUpdateProcessInstanceRequest : TeaModel {
        /// <summary>
        /// 实列列表。
        /// </summary>
        [NameInMap("updateProcessInstanceRequests")]
        [Validation(Required=false)]
        public List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests> UpdateProcessInstanceRequests { get; set; }
        public class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests : TeaModel {
            /// <summary>
            /// 实例id
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// 实例结果：
            /// 实例状态是COMPLETED，必须设置代表以下含义。
            /// agree：同意
            /// refuse：拒绝
            /// 实例状态为TERMINATED，必须设置代表含义，result取值agree和refuse均代表撤销审批流。
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// 实例状态：
            /// COMPLETED：结束审批流
            /// TERMINATED：终止审批流
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
