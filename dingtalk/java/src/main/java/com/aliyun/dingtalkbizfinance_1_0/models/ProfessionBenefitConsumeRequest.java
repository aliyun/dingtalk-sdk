// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class ProfessionBenefitConsumeRequest extends TeaModel {
    /**
     * <p>权益编码</p>
     * <br>
     */
    @NameInMap("benefitCode")
    public String benefitCode;

    /**
     * <p>幂等ID</p>
     * <br>
     */
    @NameInMap("bizRequestId")
    public String bizRequestId;

    /**
     * <p>核销数量</p>
     */
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
