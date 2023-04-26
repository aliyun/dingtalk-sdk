// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh5package_1_0.Models
{
    public class CreatePackageRequest : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("homeUrl")]
        [Validation(Required=false)]
        public string HomeUrl { get; set; }

        [NameInMap("ossObjectKey")]
        [Validation(Required=false)]
        public string OssObjectKey { get; set; }

    }

}
