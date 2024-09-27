// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetIntellectualPropertyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {       &quot;Status&quot;: &quot;有效&quot;,       &quot;Type&quot;: &quot;专利&quot;,       &quot;Pledgor&quot;: &quot;齐风莲&quot;,       &quot;Number&quot;: &quot;91611024MA70X17M7E&quot;,       &quot;Period&quot;: &quot;2015年06月11日至2015年06月11日&quot;,       &quot;PublicDate&quot;: &quot;2015-06-18 00:00:00&quot;,       &quot;Pawnee&quot;: &quot;齐风莲&quot;,       &quot;entName&quot;: &quot;东兰县鸿发摩托车安全技术检验有限公司&quot;     }   ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
