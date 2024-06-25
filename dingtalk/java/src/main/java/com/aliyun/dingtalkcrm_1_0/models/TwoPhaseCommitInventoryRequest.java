// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class TwoPhaseCommitInventoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>B_ACCOUNT_NUMBER</p>
     */
    @NameInMap("benefitCode")
    public String benefitCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>bizId</p>
     */
    @NameInMap("bizRequestId")
    public String bizRequestId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("executeResult")
    public Boolean executeResult;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("quota")
    public Long quota;

    public static TwoPhaseCommitInventoryRequest build(java.util.Map<String, ?> map) throws Exception {
        TwoPhaseCommitInventoryRequest self = new TwoPhaseCommitInventoryRequest();
        return TeaModel.build(map, self);
    }

    public TwoPhaseCommitInventoryRequest setBenefitCode(String benefitCode) {
        this.benefitCode = benefitCode;
        return this;
    }
    public String getBenefitCode() {
        return this.benefitCode;
    }

    public TwoPhaseCommitInventoryRequest setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public TwoPhaseCommitInventoryRequest setExecuteResult(Boolean executeResult) {
        this.executeResult = executeResult;
        return this;
    }
    public Boolean getExecuteResult() {
        return this.executeResult;
    }

    public TwoPhaseCommitInventoryRequest setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

}
