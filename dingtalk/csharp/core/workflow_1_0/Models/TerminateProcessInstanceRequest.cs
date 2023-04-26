// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class TerminateProcessInstanceRequest : TeaModel {
        [NameInMap("isSystem")]
        [Validation(Required=false)]
        public bool? IsSystem { get; set; }

        [NameInMap("operatingUserId")]
        [Validation(Required=false)]
        public string OperatingUserId { get; set; }

        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
