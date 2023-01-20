// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetInvestmentAbroadResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:企业名称	</p>
     * <p>InvestName:被投资企业名称	北京德润华日投资顾问有限公司</p>
     * <p>InvestCreditCode:被投资企业社会信用编码	911101073991890434</p>
     * <p>InvestLicenseNo:被投资企业注册号	110107017240281</p>
     * <p>InvestEsDate:被投资企业成立日期	2014-05-19</p>
     * <p>InvestLegalName:被投资企业法定代表人	北京星际智慧投资基金管理有限公司</p>
     * <p>InvestRegCap:被投资企业注册资本	13500.0万人民币</p>
     * <p>InvestStatus:被投资企业经营状态	在营</p>
     * <p>ShouldCap:投资数额	4000.0万人民币</p>
     * <p>StockPercentage:投资比例	19.5%</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetInvestmentAbroadResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInvestmentAbroadResponseBody self = new GetInvestmentAbroadResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInvestmentAbroadResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetInvestmentAbroadResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
