// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class RedirectWorkflowTaskRequest extends TeaModel {
    /**
     * <p>操作节点名</p>
     */
    @NameInMap("actionName")
    public String actionName;

    /**
     * <p>操作人的用户ID，需要跟任务的当前执行人保持一致，否则无法通过校验</p>
     */
    @NameInMap("operateUserId")
    public String operateUserId;

    /**
     * <p>转交备注信息</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>OA审批任务ID</p>
     */
    @NameInMap("taskId")
    public Long taskId;

    /**
     * <p>OA审批任务被转交对象的用户ID</p>
     */
    @NameInMap("toUserId")
    public String toUserId;

    public static RedirectWorkflowTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        RedirectWorkflowTaskRequest self = new RedirectWorkflowTaskRequest();
        return TeaModel.build(map, self);
    }

    public RedirectWorkflowTaskRequest setActionName(String actionName) {
        this.actionName = actionName;
        return this;
    }
    public String getActionName() {
        return this.actionName;
    }

    public RedirectWorkflowTaskRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

    public RedirectWorkflowTaskRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public RedirectWorkflowTaskRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

    public RedirectWorkflowTaskRequest setToUserId(String toUserId) {
        this.toUserId = toUserId;
        return this;
    }
    public String getToUserId() {
        return this.toUserId;
    }

}
