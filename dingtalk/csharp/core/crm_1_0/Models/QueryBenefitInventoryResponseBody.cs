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
            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("totalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

    }

}
