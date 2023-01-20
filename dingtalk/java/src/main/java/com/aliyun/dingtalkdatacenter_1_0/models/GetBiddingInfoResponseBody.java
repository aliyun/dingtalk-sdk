// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBiddingInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:企业名称</p>
     * <p>BidTitle:标文标题</p>
     * <p>BidType:招标方式</p>
     * <p>RegionName:地区</p>
     * <p>BidIndustry:标的所属行业</p>
     * <p>PublicDate:发布时间</p>
     * <p>ProjectNum:项目编号</p>
     * <p>ProjectName:项目名称</p>
     * <p>ProjectAmount:项目金额</p>
     * <p>TenderEntName:招标企业</p>
     * <p>AgentEntName:代理企业</p>
     * <p>WinnerEntName:中标企业</p>
     * <p>Content:正文</p>
     * <p>InfoType:标文类型</p>
     * <p>SubType:子类型</p>
     * <p>OpeningTime:开标时间</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
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
