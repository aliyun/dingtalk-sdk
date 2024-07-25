// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryBenefitResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryBenefitResponseBodyResult Result { get; set; }
        public class QueryBenefitResponseBodyResult : TeaModel {
            [NameInMap("remainQuota")]
            [Validation(Required=false)]
            public long? RemainQuota { get; set; }

            [NameInMap("totalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

        }

    }

}
