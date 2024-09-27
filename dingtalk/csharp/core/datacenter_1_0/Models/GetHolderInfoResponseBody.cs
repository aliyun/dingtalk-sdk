// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetHolderInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;STOCK_TYPE&quot;: &quot;企业法人&quot;,       &quot;STOCK_NAME&quot;: &quot;xxx&quot;,       &quot;STOCK_PERCENT&quot;: &quot;100.00%&quot;,       &quot;SHOULD_CAPI&quot;: &quot;1000.0&quot;,       &quot;SHOULD_CAPI_TIME&quot;: &quot;2007-09-28&quot;     }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
