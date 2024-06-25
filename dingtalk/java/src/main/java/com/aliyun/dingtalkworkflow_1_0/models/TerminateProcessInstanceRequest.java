// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class TerminateProcessInstanceRequest extends TeaModel {
    @NameInMap("isSystem")
    public Boolean isSystem;

    /**
     * <strong>example:</strong>
     * <p>133743186427339452</p>
     */
    @NameInMap("operatingUserId")
    public String operatingUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a171de6c-8bxxxx</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <strong>example:</strong>
     * <p>终止说明。</p>
     */
    @NameInMap("remark")
    public String remark;

    public static TerminateProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        TerminateProcessInstanceRequest self = new TerminateProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public TerminateProcessInstanceRequest setIsSystem(Boolean isSystem) {
        this.isSystem = isSystem;
        return this;
    }
    public Boolean getIsSystem() {
        return this.isSystem;
    }

    public TerminateProcessInstanceRequest setOperatingUserId(String operatingUserId) {
        this.operatingUserId = operatingUserId;
        return this;
    }
    public String getOperatingUserId() {
        return this.operatingUserId;
    }

    public TerminateProcessInstanceRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public TerminateProcessInstanceRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

}
