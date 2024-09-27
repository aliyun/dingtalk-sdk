// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetBranchInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;OperName&quot;: &quot;李柯&quot;,       &quot;EntStatus&quot;: &quot;&quot;,       &quot;EntName&quot;: &quot;华为技术有限公司驻广州办事处&quot;,       &quot;EsDate&quot;: &quot;&quot;     },     {       &quot;OperName&quot;: &quot;李实&quot;,       &quot;EntStatus&quot;: &quot;&quot;,       &quot;EntName&quot;: &quot;华为技术有限公司重庆分公司&quot;,       &quot;EsDate&quot;: &quot;&quot;     } ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
