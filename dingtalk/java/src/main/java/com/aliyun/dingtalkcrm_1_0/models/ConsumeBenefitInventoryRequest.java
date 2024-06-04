// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ConsumeBenefitInventoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("benefitCode")
    public String benefitCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizRequestId")
    public String bizRequestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("consumeQuota")
    public Long consumeQuota;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    public static ConsumeBenefitInventoryRequest build(java.util.Map<String, ?> map) throws Exception {
        ConsumeBenefitInventoryRequest self = new ConsumeBenefitInventoryRequest();
        return TeaModel.build(map, self);
    }

    public ConsumeBenefitInventoryRequest setBenefitCode(String benefitCode) {
        this.benefitCode = benefitCode;
        return this;
    }
    public String getBenefitCode() {
        return this.benefitCode;
    }

    public ConsumeBenefitInventoryRequest setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public ConsumeBenefitInventoryRequest setConsumeQuota(Long consumeQuota) {
        this.consumeQuota = consumeQuota;
        return this;
    }
    public Long getConsumeQuota() {
        return this.consumeQuota;
    }

    public ConsumeBenefitInventoryRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

}
