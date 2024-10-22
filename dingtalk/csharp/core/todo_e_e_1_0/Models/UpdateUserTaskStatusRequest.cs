// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class UpdateUserTaskStatusRequest : TeaModel {
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("userTaskStatuses")]
        [Validation(Required=false)]
        public List<UpdateUserTaskStatusRequestUserTaskStatuses> UserTaskStatuses { get; set; }
        public class UpdateUserTaskStatusRequestUserTaskStatuses : TeaModel {
            [NameInMap("done")]
            [Validation(Required=false)]
            public bool? Done { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
