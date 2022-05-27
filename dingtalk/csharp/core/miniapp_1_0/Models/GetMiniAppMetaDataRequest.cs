// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminiapp_1_0.Models
{
    public class GetMiniAppMetaDataRequest : TeaModel {
        [NameInMap("bundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("bundleIdTableGmtModified")]
        [Validation(Required=false)]
        public Dictionary<string, object> BundleIdTableGmtModified { get; set; }

        [NameInMap("fromAppName")]
        [Validation(Required=false)]
        public string FromAppName { get; set; }

        [NameInMap("miniAppIdTableGmtModified")]
        [Validation(Required=false)]
        public Dictionary<string, object> MiniAppIdTableGmtModified { get; set; }

    }

}
