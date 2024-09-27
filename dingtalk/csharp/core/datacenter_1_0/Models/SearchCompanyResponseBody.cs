// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class SearchCompanyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;ENT_NAME&quot;: &quot;xx&quot;,       &quot;SOCIAL_CREDIT_CODE&quot;: &quot;xx&quot;,       &quot;LICENSE_NUMBER&quot;: &quot;xx&quot;,       &quot;REG_CAP&quot;: &quot;10000000.0&quot;,       &quot;ES_DATE&quot;: &quot;2006-12-07&quot;,       &quot;LEGAL_NAME&quot;: &quot;xx&quot;,       &quot;ORG_NO&quot;: &quot;xx&quot;,       &quot;TAX_NUM&quot;: &quot;xx&quot;,       &quot;ENT_STATUS&quot;: &quot;在营&quot;     }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
