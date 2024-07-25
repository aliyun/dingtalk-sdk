// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BeginConsumeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>B_SF2_INVOICE_OCR</p>
     */
    @NameInMap("benefitCode")
    public String benefitCode;

    /**
     * <strong>example:</strong>
     * <p>XXX</p>
     */
    @NameInMap("bizRequestId")
    public String bizRequestId;

    @NameInMap("quota")
    public Long quota;

    @NameInMap("userId")
    public String userId;

    public static BeginConsumeRequest build(java.util.Map<String, ?> map) throws Exception {
        BeginConsumeRequest self = new BeginConsumeRequest();
        return TeaModel.build(map, self);
    }

    public BeginConsumeRequest setBenefitCode(String benefitCode) {
        this.benefitCode = benefitCode;
        return this;
    }
    public String getBenefitCode() {
        return this.benefitCode;
    }

    public BeginConsumeRequest setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public BeginConsumeRequest setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

    public BeginConsumeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
