// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetQeneralTaxpayerInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;DEPARTMENT&quot;:&quot;xx&quot;       &quot;END_DATE&quot;:&quot;2017-01-04&quot;       &quot;ENT_NAME&quot;:&quot;xx&quot;       &quot;QUALIFICATION&quot;       &quot;START_DATE&quot;:&quot;2017-01-04&quot;       &quot;TAXPAYER_NUM&quot;:&quot;11&quot;       &quot;JUDGE_DATE&quot;:&quot;2017-05-04&quot;      }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
