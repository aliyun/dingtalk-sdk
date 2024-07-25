// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBenefitRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>B_SF2_INVOICE_CHECK_V2</p>
     */
    @NameInMap("benefitCode")
    public String benefitCode;

    public static QueryBenefitRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBenefitRequest self = new QueryBenefitRequest();
        return TeaModel.build(map, self);
    }

    public QueryBenefitRequest setBenefitCode(String benefitCode) {
        this.benefitCode = benefitCode;
        return this;
    }
    public String getBenefitCode() {
        return this.benefitCode;
    }

}
