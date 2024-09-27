// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetPrincipalEmployeeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;JobTitle&quot;: &quot;董事长&quot;,       &quot;Name&quot;: &quot;梁华&quot;     },     {       &quot;JobTitle&quot;: &quot;副董事长&quot;,       &quot;Name&quot;: &quot;孟晚舟&quot;     },     {       &quot;JobTitle&quot;: &quot;副董事长&quot;,       &quot;Name&quot;: &quot;徐直军&quot;     }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
