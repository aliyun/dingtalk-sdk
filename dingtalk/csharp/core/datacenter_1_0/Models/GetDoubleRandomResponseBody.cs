// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetDoubleRandomResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;InspectPlanId&quot;: &quot;44030020191021&quot;,       &quot;InspectTypeName&quot;: &quot;定向&quot;,       &quot;InspectPlanName&quot;: &quot;2019能效标识生产企业计量监督抽查1&quot;,       &quot;InspectItem&quot;: &quot;&quot;,       &quot;InspectResult&quot;: &quot;&quot;,       &quot;InspectDepartment&quot;: &quot;深圳市市场监督管理局龙岗局&quot;,       &quot;InspectDate&quot;: &quot;2019-10-14&quot;,       &quot;InspectTaskId&quot;: &quot;44030020191021&quot;,       &quot;InspectTaskName&quot;: &quot;2019能效标识生产企业计量监督抽查1&quot;     }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
