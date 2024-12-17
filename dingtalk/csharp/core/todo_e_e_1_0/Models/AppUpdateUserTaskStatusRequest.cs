// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class AppUpdateUserTaskStatusRequest : TeaModel {
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("userTaskStatuses")]
        [Validation(Required=false)]
        public List<AppUpdateUserTaskStatusRequestUserTaskStatuses> UserTaskStatuses { get; set; }
        public class AppUpdateUserTaskStatusRequestUserTaskStatuses : TeaModel {
            [NameInMap("done")]
            [Validation(Required=false)]
            public bool? Done { get; set; }

            /// <summary>
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
