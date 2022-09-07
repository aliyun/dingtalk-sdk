// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class TerminateProcessInstanceRequest extends TeaModel {
    // 是否通过系统操作：
    // 
    // true：由系统直接终止
    // 
    // false：由指定的操作者终止
    @NameInMap("isSystem")
    public Boolean isSystem;

    // 操作人的userid。
    // 
    // 当is_system为false时，该参数必传。
    @NameInMap("operatingUserId")
    public String operatingUserId;

    // 审批实例ID，可通过调用获取审批实例ID列表接口获取。
    @NameInMap("processInstanceId")
    public String processInstanceId;

    // 终止说明。
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
