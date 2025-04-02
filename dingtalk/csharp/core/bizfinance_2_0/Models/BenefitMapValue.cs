// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class BenefitMapValue : TeaModel {
        [NameInMap("canUse")]
        [Validation(Required=false)]
        public bool? CanUse { get; set; }

        [NameInMap("canUseQuota")]
        [Validation(Required=false)]
        public long? CanUseQuota { get; set; }

        [NameInMap("usedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

    }

}
