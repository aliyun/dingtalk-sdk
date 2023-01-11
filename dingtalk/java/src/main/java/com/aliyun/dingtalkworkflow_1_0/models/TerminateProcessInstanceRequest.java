// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class TerminateProcessInstanceRequest extends TeaModel {
    /**
     * <p>是否通过系统操作：</p>
     * <br>
     * <p>true：由系统直接终止</p>
     * <br>
     * <p>false：由指定的操作者终止</p>
     */
    @NameInMap("isSystem")
    public Boolean isSystem;

    /**
     * <p>操作人的userid。</p>
     * <br>
     * <p>当is_system为false时，该参数必传。</p>
     */
    @NameInMap("operatingUserId")
    public String operatingUserId;

    /**
     * <p>审批实例ID，可通过调用获取审批实例ID列表接口获取。</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
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
