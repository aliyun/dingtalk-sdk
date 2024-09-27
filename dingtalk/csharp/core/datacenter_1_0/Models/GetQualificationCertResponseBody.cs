// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetQualificationCertResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;EntName&quot;:&quot;企业名称&quot;, &quot;CertType&quot;:&quot;证书类型&quot;, &quot;CertNum&quot;:&quot;证书认证编号&quot;, &quot;ValidStartDate&quot;:&quot;有效期开始日期&quot;, &quot;ValidEndDate&quot;:&quot;有效期截止日期&quot;, &quot;AuthorizeDate&quot;:&quot;授权日期&quot;, &quot;AuthorizeDepartment&quot;:&quot;授权部门&quot;, &quot;PubDate&quot;:&quot;公示日期&quot;, &quot;Province&quot;:&quot;省份&quot;, &quot;CertScope&quot;:&quot;认证范围&quot;} ]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
