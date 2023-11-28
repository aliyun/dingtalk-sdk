// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ShareUrlRequest : TeaModel {
        [NameInMap("param")]
        [Validation(Required=false)]
        public ShareUrlRequestParam Param { get; set; }
        public class ShareUrlRequestParam : TeaModel {
            [NameInMap("dentryUuid")]
            [Validation(Required=false)]
            public string DentryUuid { get; set; }

            [NameInMap("triggerShare")]
            [Validation(Required=false)]
            public bool? TriggerShare { get; set; }

        }

    }

}
