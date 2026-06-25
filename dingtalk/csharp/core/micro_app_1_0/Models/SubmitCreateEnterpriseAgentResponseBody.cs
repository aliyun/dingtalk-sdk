// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class SubmitCreateEnterpriseAgentResponseBody : TeaModel {
        [NameInMap("expiresIn")]
        [Validation(Required=false)]
        public string ExpiresIn { get; set; }

        [NameInMap("interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("retryCount")]
        [Validation(Required=false)]
        public string RetryCount { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
