// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CommitConsumeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>B_SF2_INVOICE_OCR</p>
     */
    @NameInMap("benefitCode")
    public String benefitCode;

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

    public static CommitConsumeRequest build(java.util.Map<String, ?> map) throws Exception {
        CommitConsumeRequest self = new CommitConsumeRequest();
        return TeaModel.build(map, self);
    }

    public CommitConsumeRequest setBenefitCode(String benefitCode) {
        this.benefitCode = benefitCode;
        return this;
    }
    public String getBenefitCode() {
        return this.benefitCode;
    }

    public CommitConsumeRequest setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public CommitConsumeRequest setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

    public CommitConsumeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
