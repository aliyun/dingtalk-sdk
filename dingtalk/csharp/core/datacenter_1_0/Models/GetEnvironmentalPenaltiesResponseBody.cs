// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetEnvironmentalPenaltiesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;DEPARTMENT&quot;: &quot;xx&quot;,       &quot;ENT_NAME&quot;: &quot;xx&quot;,       &quot;EXEC_STATUS&quot;: &quot;xx&quot;,       &quot;PUNISH_BASIS&quot;: &quot;xx&quot;,       &quot;PUNISH_CONTENT&quot;: &quot;xx&quot;,       &quot;PUNISH_LAW&quot;: &quot;xx&quot;,       &quot;PUNISH_NUM&quot;: &quot;xx&quot;,       &quot;PUNISH_RES&quot;: &quot;xx&quot;,       &quot;PUNISH_DATE&quot;: &quot;xx&quot;      }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
