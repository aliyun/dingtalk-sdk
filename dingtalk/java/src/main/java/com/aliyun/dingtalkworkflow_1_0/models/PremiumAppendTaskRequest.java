// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumAppendTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ALL</p>
     */
    @NameInMap("activateType")
    public String activateType;

    @NameInMap("agreeAll")
    public Boolean agreeAll;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appenderUserIds")
    public java.util.List<String> appenderUserIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager001</p>
     */
    @NameInMap("operateUserId")
    public String operateUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>processInstanceId123</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <strong>example:</strong>
     * <p>请XX帮忙审批一下</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234567</p>
     */
    @NameInMap("taskId")
    public Long taskId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>after</p>
     */
    @NameInMap("type")
    public String type;

    public static PremiumAppendTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumAppendTaskRequest self = new PremiumAppendTaskRequest();
        return TeaModel.build(map, self);
    }

    public PremiumAppendTaskRequest setActivateType(String activateType) {
        this.activateType = activateType;
        return this;
    }
    public String getActivateType() {
        return this.activateType;
    }

    public PremiumAppendTaskRequest setAgreeAll(Boolean agreeAll) {
        this.agreeAll = agreeAll;
        return this;
    }
    public Boolean getAgreeAll() {
        return this.agreeAll;
    }

    public PremiumAppendTaskRequest setAppenderUserIds(java.util.List<String> appenderUserIds) {
        this.appenderUserIds = appenderUserIds;
        return this;
    }
    public java.util.List<String> getAppenderUserIds() {
        return this.appenderUserIds;
    }

    public PremiumAppendTaskRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

    public PremiumAppendTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public PremiumAppendTaskRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public PremiumAppendTaskRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

    public PremiumAppendTaskRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
