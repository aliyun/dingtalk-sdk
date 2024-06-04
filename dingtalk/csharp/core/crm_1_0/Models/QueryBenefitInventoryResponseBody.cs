// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryBenefitInventoryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryBenefitInventoryResponseBodyResult Result { get; set; }
        public class QueryBenefitInventoryResponseBodyResult : TeaModel {
            [NameInMap("totalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

    }

}
