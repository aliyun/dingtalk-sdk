// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetDomainInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{ &quot;EntName&quot;:&quot;企业名称&quot; &quot;Number&quot;:&quot;备案号&quot; &quot;Domain&quot;:&quot;域名&quot; &quot;SiteName&quot;:&quot;网站名称&quot; &quot;HomeUrl&quot;:&quot;网站首页链接&quot; &quot;CheckDate&quot;:&quot;备案日期&quot; }]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
