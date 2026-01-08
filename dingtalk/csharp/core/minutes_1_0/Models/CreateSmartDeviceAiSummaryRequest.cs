// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class CreateSmartDeviceAiSummaryRequest : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("isvContext")]
        [Validation(Required=false)]
        public string IsvContext { get; set; }

        [NameInMap("openFileId")]
        [Validation(Required=false)]
        public string OpenFileId { get; set; }

    }

}
