// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetInvestmentAbroadResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[     {       &quot;InvestLicenseNo&quot;: &quot;440301104818958&quot;,       &quot;InvestStatus&quot;: &quot;在营&quot;,       &quot;InvestEsDate&quot;: &quot;1998-11-25&quot;,       &quot;InvestCreditCode&quot;: &quot;914403007084643962&quot;,       &quot;ShouldCap&quot;: &quot;2000.0万人民币&quot;,       &quot;EntName&quot;: &quot;华为技术有限公司&quot;,       &quot;InvestLegalName&quot;: &quot;汤启兵&quot;,       &quot;StockPercentage&quot;: &quot;100.0%&quot;,       &quot;InvestName&quot;: &quot;深圳市华为技术服务有限公司&quot;,       &quot;InvestRegCap&quot;: &quot;2000.0万人民币&quot;     }   ]</p>
     */
    @NameInMap("data")
    public String data;

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
