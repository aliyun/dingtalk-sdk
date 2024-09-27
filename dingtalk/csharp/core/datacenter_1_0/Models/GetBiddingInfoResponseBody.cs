// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetBiddingInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{ &quot;EntName&quot;:&quot;企业名称&quot;, &quot;BidTitle&quot;:&quot;标文标题&quot;, &quot;BidType&quot;:&quot;招标方式&quot;, &quot;RegionName&quot;:&quot;地区&quot;, &quot;BidIndustry&quot;:&quot;标的所属行业&quot;, &quot;PublicDate&quot;:&quot;发布时间&quot;, &quot;ProjectNum&quot;:&quot;项目编号&quot;, &quot;ProjectName&quot;:&quot;项目名称&quot;, &quot;ProjectAmount&quot;:&quot;项目金额&quot;, &quot;TenderEntName&quot;:&quot;招标企业&quot;, &quot;AgentEntName&quot;:&quot;代理企业&quot;, &quot;WinnerEntName&quot;:&quot;中标企业&quot;, &quot;Content&quot;:&quot;正文&quot;, &quot;InfoType&quot;:&quot;标文类型&quot;, &quot;SubType&quot;:&quot;子类型&quot;, &quot;OpeningTime&quot;:&quot;开标时间&quot; }]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
