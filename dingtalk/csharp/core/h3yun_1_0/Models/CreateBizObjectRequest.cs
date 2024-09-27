// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class CreateBizObjectRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;F0000010&quot;: &quot;0000004&quot;, &quot;F0000011&quot;: &quot;王五1&quot;,&quot;F0000012&quot;: &quot;D1级客户&quot;,&quot;F0000013&quot;: 7000,&quot;D000183Fcd15f3a51e624bbc9945392d190b6aa8&quot;: [{&quot;F0000014&quot;: &quot;里斯&quot;,&quot;F0000015&quot;: 156666365656, &quot;F0000016&quot;: &quot;技术部&quot;,&quot;F0000017&quot;: &quot;经理1&quot;,&quot;F0000018&quot;:&quot;男&quot;,&quot;F0000019&quot;: &quot;<a href="mailto:lgbxunmi@dd.com">lgbxunmi@dd.com</a>&quot;, &quot;F0000020&quot;: true, &quot;F0000021&quot;: &quot;测试数据&quot;}]}</para>
        /// </summary>
        [NameInMap("bizObjectJson")]
        [Validation(Required=false)]
        public string BizObjectJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isDraft")]
        [Validation(Required=false)]
        public bool? IsDraft { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aea4d7a7-d162-4c77-9c44-7bd9cb8316a5</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0001839bbbbe346bbf496498bb76c44c7eb972</para>
        /// </summary>
        [NameInMap("schemaCode")]
        [Validation(Required=false)]
        public string SchemaCode { get; set; }

    }

}
