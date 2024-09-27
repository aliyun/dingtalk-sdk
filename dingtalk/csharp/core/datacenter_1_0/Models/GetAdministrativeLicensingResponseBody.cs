// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetAdministrativeLicensingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;LicenseNo&quot;: &quot;梯4403331978&quot;,       &quot;StartDate&quot;: &quot;2022-05-10&quot;,       &quot;Department&quot;: &quot;深圳市市场监督管理局&quot;,       &quot;Content&quot;: &quot;注册代码:7;设备种类:电梯&quot;,       &quot;LicenseName&quot;: &quot;特种设备使用登记&quot;,       &quot;EndDate&quot;: &quot;2099-12-31&quot;     },     {       &quot;LicenseNo&quot;: &quot;东水务审﹝2021﹞8267号&quot;,       &quot;StartDate&quot;: &quot;2021-06-11&quot;,       &quot;Department&quot;: &quot;东莞市水务局&quot;,       &quot;Content&quot;: &quot;水土保持方案审批准予行政许可决定&quot;,       &quot;LicenseName&quot;: &quot;&quot;,       &quot;EndDate&quot;: &quot;2026-12-31&quot;     } ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
