// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SubmitTaskResponseBody : TeaModel {
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<SubmitTaskResponseBodyTasks> Tasks { get; set; }
        public class SubmitTaskResponseBodyTasks : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
