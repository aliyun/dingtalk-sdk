// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class BatchExecuteProcessInstancesRequest : TeaModel {
        [NameInMap("actionerUserId")]
        [Validation(Required=false)]
        public string ActionerUserId { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        [NameInMap("taskInfoList")]
        [Validation(Required=false)]
        public List<BatchExecuteProcessInstancesRequestTaskInfoList> TaskInfoList { get; set; }
        public class BatchExecuteProcessInstancesRequestTaskInfoList : TeaModel {
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

    }

}
