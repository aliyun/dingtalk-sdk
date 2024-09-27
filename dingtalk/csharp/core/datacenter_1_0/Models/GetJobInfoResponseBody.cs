// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetJobInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;DEPARTMENT&quot;: &quot;xx&quot;,       &quot;IN_REASON&quot;: &quot;xx&quot;,       &quot;OUT_DATE&quot;: &quot;2006-12-07&quot;,       &quot;OUT_DEPARTMENT&quot;: &quot;xx&quot;,       &quot;IN_DATE&quot;: &quot;2006-12-07&quot;,       &quot;OUT_REASON&quot;: &quot;xx&quot;     }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
