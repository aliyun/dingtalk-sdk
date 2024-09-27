// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetAdministrativePenaltiesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;DATE_COL&quot;: &quot;xx&quot;,       &quot;NUMBER&quot;: &quot;xx&quot;,       &quot;ILLEGAL_TYPE&quot;: &quot;xx&quot;,       &quot;DEPARTMENT&quot;: &quot;xx&quot;,       &quot;PUBLIC_DATE&quot;: &quot;xx&quot;,       &quot;CONTENT&quot;: &quot;xx&quot;,       &quot;BASED_ON&quot;:&quot;xx&quot;,       &quot;DESCRIPTION&quot;:&quot;xx&quot;      }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
