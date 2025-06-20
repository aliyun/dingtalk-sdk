// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumRevertTaskRequest extends TeaModel {
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
     * <p>退回到审批人（上一步）</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>REVERT_FOR_APPROVAL</p>
     */
    @NameInMap("revertAction")
    public String revertAction;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>d3aa_1974</p>
     */
    @NameInMap("targetActivityId")
    public String targetActivityId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234567</p>
     */
    @NameInMap("taskId")
    public Long taskId;

    public static PremiumRevertTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumRevertTaskRequest self = new PremiumRevertTaskRequest();
        return TeaModel.build(map, self);
    }

    public PremiumRevertTaskRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

    public PremiumRevertTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public PremiumRevertTaskRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public PremiumRevertTaskRequest setRevertAction(String revertAction) {
        this.revertAction = revertAction;
        return this;
    }
    public String getRevertAction() {
        return this.revertAction;
    }

    public PremiumRevertTaskRequest setTargetActivityId(String targetActivityId) {
        this.targetActivityId = targetActivityId;
        return this;
    }
    public String getTargetActivityId() {
        return this.targetActivityId;
    }

    public PremiumRevertTaskRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
