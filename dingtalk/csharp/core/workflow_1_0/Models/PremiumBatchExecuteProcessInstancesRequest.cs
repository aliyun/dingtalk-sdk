// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumBatchExecuteProcessInstancesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("actionerUserId")]
        [Validation(Required=false)]
        public string ActionerUserId { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskInfoList")]
        [Validation(Required=false)]
        public List<PremiumBatchExecuteProcessInstancesRequestTaskInfoList> TaskInfoList { get; set; }
        public class PremiumBatchExecuteProcessInstancesRequestTaskInfoList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

    }

}
