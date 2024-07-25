// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CancelConsumeRequest extends TeaModel {
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

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("quota")
    public Long quota;

    @NameInMap("userId")
    public String userId;

    public static CancelConsumeRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelConsumeRequest self = new CancelConsumeRequest();
        return TeaModel.build(map, self);
    }

    public CancelConsumeRequest setBenefitCode(String benefitCode) {
        this.benefitCode = benefitCode;
        return this;
    }
    public String getBenefitCode() {
        return this.benefitCode;
    }

    public CancelConsumeRequest setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public CancelConsumeRequest setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

    public CancelConsumeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
