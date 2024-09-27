// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetInvestmentAbroadResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;InvestLicenseNo&quot;: &quot;440301104818958&quot;,       &quot;InvestStatus&quot;: &quot;在营&quot;,       &quot;InvestEsDate&quot;: &quot;1998-11-25&quot;,       &quot;InvestCreditCode&quot;: &quot;914403007084643962&quot;,       &quot;ShouldCap&quot;: &quot;2000.0万人民币&quot;,       &quot;EntName&quot;: &quot;华为技术有限公司&quot;,       &quot;InvestLegalName&quot;: &quot;汤启兵&quot;,       &quot;StockPercentage&quot;: &quot;100.0%&quot;,       &quot;InvestName&quot;: &quot;深圳市华为技术服务有限公司&quot;,       &quot;InvestRegCap&quot;: &quot;2000.0万人民币&quot;     }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
