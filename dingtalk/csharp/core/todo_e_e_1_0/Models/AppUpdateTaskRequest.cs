// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class AppUpdateTaskRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
