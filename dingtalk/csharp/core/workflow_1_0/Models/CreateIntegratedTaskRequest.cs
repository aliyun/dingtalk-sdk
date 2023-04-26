// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class CreateIntegratedTaskRequest : TeaModel {
        [NameInMap("activityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<CreateIntegratedTaskRequestTasks> Tasks { get; set; }
        public class CreateIntegratedTaskRequestTasks : TeaModel {
            [NameInMap("customData")]
            [Validation(Required=false)]
            public string CustomData { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
