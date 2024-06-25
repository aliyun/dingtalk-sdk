// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class ProfessionBenefitConsumeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>SF_INVOICE</p>
     */
    @NameInMap("benefitCode")
    public String benefitCode;

    /**
     * <strong>example:</strong>
     * <p>1234567890</p>
     */
    @NameInMap("bizRequestId")
    public String bizRequestId;

    @NameInMap("quota")
    public Long quota;

    public static ProfessionBenefitConsumeRequest build(java.util.Map<String, ?> map) throws Exception {
        ProfessionBenefitConsumeRequest self = new ProfessionBenefitConsumeRequest();
        return TeaModel.build(map, self);
    }

    public ProfessionBenefitConsumeRequest setBenefitCode(String benefitCode) {
        this.benefitCode = benefitCode;
        return this;
    }
    public String getBenefitCode() {
        return this.benefitCode;
    }

    public ProfessionBenefitConsumeRequest setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public ProfessionBenefitConsumeRequest setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

}
