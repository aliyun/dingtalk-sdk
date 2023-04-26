// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class DeployFunctionCallbackRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("customDomain")]
        [Validation(Required=false)]
        public string CustomDomain { get; set; }

        [NameInMap("deployStage")]
        [Validation(Required=false)]
        public string DeployStage { get; set; }

        [NameInMap("gateWayAppKey")]
        [Validation(Required=false)]
        public string GateWayAppKey { get; set; }

        [NameInMap("gateWayAppSecret")]
        [Validation(Required=false)]
        public string GateWayAppSecret { get; set; }

        [NameInMap("gateWayDomain")]
        [Validation(Required=false)]
        public string GateWayDomain { get; set; }

    }

}
