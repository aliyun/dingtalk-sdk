// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetWorkCopyrightResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{ &quot;EntName&quot;:&quot;企业名称&quot;, &quot;CopyName&quot;:&quot;作品全称&quot;, &quot;TypeName&quot;:&quot;作品类别&quot;, &quot;CopyNum&quot;:&quot;登记号&quot;, &quot;SuccessDate&quot;:&quot;创作完成日期&quot;, &quot;FirstDate&quot;:&quot;首次发表日期&quot;, &quot;ApprovalDate&quot;:&quot;登记批准日期&quot; }]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
