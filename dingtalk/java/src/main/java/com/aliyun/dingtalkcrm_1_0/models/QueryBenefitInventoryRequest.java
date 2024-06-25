// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryBenefitInventoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>B_CUSTOMER_CAPACITY</p>
     */
    @NameInMap("benefitCode")
    public String benefitCode;

    public static QueryBenefitInventoryRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBenefitInventoryRequest self = new QueryBenefitInventoryRequest();
        return TeaModel.build(map, self);
    }

    public QueryBenefitInventoryRequest setBenefitCode(String benefitCode) {
        this.benefitCode = benefitCode;
        return this;
    }
    public String getBenefitCode() {
        return this.benefitCode;
    }

}
