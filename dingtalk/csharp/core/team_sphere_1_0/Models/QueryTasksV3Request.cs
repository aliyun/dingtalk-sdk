// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class QueryTasksV3Request : TeaModel {
        [NameInMap("parentTaskId")]
        [Validation(Required=false)]
        public string ParentTaskId { get; set; }

        [NameInMap("shortIds")]
        [Validation(Required=false)]
        public string ShortIds { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
