// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetPatentInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;EntName&quot;:&quot;企业名称&quot;, &quot;PatentType&quot;:&quot;专利类型&quot;, &quot;PatentName&quot;:&quot;专利名&quot;, &quot;PatentStatus&quot;:&quot;专利状态&quot;, &quot;RequestNum&quot;:&quot;申请号&quot;, &quot;RequestDate&quot;:&quot;申请日&quot;, &quot;PublicNum&quot;:&quot;公开(公告)号&quot;, &quot;PublicDate&quot;:&quot;公开(公告)日&quot;, &quot;InventorList&quot;:&quot;发明人&quot;, &quot;PatenteeList&quot;:&quot;专利权人&quot;, &quot;CateNum&quot;:&quot;分类号&quot;, &quot;PrioNum&quot;:&quot;优先权号&quot;, &quot;PrioDate&quot;:&quot;优先权日&quot;, &quot;Agency&quot;:&quot;专利代理机构&quot;, &quot;Agent&quot;:&quot;代理人&quot;, &quot;Brief&quot;:&quot;简要说明&quot;, &quot;MainClaim&quot;:&quot;主权项&quot;}]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
