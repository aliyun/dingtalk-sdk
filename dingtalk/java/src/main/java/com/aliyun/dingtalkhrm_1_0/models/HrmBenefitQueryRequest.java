// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmBenefitQueryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("benefitCodes")
    public java.util.List<String> benefitCodes;

    public static HrmBenefitQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmBenefitQueryRequest self = new HrmBenefitQueryRequest();
        return TeaModel.build(map, self);
    }

    public HrmBenefitQueryRequest setBenefitCodes(java.util.List<String> benefitCodes) {
        this.benefitCodes = benefitCodes;
        return this;
    }
    public java.util.List<String> getBenefitCodes() {
        return this.benefitCodes;
    }

}
