// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SyncSolutionStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>start</p>
     */
    @NameInMap("solutionStatus")
    public String solutionStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>onboarding_v2</p>
     */
    @NameInMap("solutionType")
    public String solutionType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12</p>
     */
    @NameInMap("tenantId")
    public Long tenantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static SyncSolutionStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncSolutionStatusRequest self = new SyncSolutionStatusRequest();
        return TeaModel.build(map, self);
    }

    public SyncSolutionStatusRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public SyncSolutionStatusRequest setSolutionStatus(String solutionStatus) {
        this.solutionStatus = solutionStatus;
        return this;
    }
    public String getSolutionStatus() {
        return this.solutionStatus;
    }

    public SyncSolutionStatusRequest setSolutionType(String solutionType) {
        this.solutionType = solutionType;
        return this;
    }
    public String getSolutionType() {
        return this.solutionType;
    }

    public SyncSolutionStatusRequest setTenantId(Long tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public Long getTenantId() {
        return this.tenantId;
    }

    public SyncSolutionStatusRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
