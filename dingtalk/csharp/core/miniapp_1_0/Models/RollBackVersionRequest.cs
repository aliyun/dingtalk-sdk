// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminiapp_1_0.Models
{
    public class RollBackVersionRequest : TeaModel {
        [NameInMap("bundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("miniAppId")]
        [Validation(Required=false)]
        public string MiniAppId { get; set; }

        [NameInMap("rollbackVersion")]
        [Validation(Required=false)]
        public string RollbackVersion { get; set; }

        [NameInMap("targetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
