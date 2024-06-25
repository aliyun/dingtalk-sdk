// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBiddingInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[{ &quot;EntName&quot;:&quot;企业名称&quot;, &quot;BidTitle&quot;:&quot;标文标题&quot;, &quot;BidType&quot;:&quot;招标方式&quot;, &quot;RegionName&quot;:&quot;地区&quot;, &quot;BidIndustry&quot;:&quot;标的所属行业&quot;, &quot;PublicDate&quot;:&quot;发布时间&quot;, &quot;ProjectNum&quot;:&quot;项目编号&quot;, &quot;ProjectName&quot;:&quot;项目名称&quot;, &quot;ProjectAmount&quot;:&quot;项目金额&quot;, &quot;TenderEntName&quot;:&quot;招标企业&quot;, &quot;AgentEntName&quot;:&quot;代理企业&quot;, &quot;WinnerEntName&quot;:&quot;中标企业&quot;, &quot;Content&quot;:&quot;正文&quot;, &quot;InfoType&quot;:&quot;标文类型&quot;, &quot;SubType&quot;:&quot;子类型&quot;, &quot;OpeningTime&quot;:&quot;开标时间&quot; }]</p>
     */
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetBiddingInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBiddingInfoResponseBody self = new GetBiddingInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBiddingInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetBiddingInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
