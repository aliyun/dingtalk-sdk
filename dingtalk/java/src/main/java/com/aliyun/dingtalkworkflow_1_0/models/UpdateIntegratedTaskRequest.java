// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class UpdateIntegratedTaskRequest extends TeaModel {
    // OA审批流程实例ID，过创建实例接口获取
    @NameInMap("processInstanceId")
    public String processInstanceId;

    @NameInMap("tasks")
    public java.util.List<UpdateIntegratedTaskRequestTasks> tasks;

    public static UpdateIntegratedTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateIntegratedTaskRequest self = new UpdateIntegratedTaskRequest();
        return TeaModel.build(map, self);
    }

    public UpdateIntegratedTaskRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public UpdateIntegratedTaskRequest setTasks(java.util.List<UpdateIntegratedTaskRequestTasks> tasks) {
        this.tasks = tasks;
        return this;
    }
    public java.util.List<UpdateIntegratedTaskRequestTasks> getTasks() {
        return this.tasks;
    }

    public static class UpdateIntegratedTaskRequestTasks extends TeaModel {
        // 当status为COMPLETED时，必须指定任务结果：
        // AGREE：同意
        // REFUSE：拒绝
        // 
        // 说明 当status为CANCELED时，不需要传result。
        @NameInMap("result")
        public String result;

        // 更新为目标任务状态，可选值 CANCELED、COMPLETED
        @NameInMap("status")
        public String status;

        // OA审批任务ID
        @NameInMap("taskId")
        public Long taskId;

        public static UpdateIntegratedTaskRequestTasks build(java.util.Map<String, ?> map) throws Exception {
            UpdateIntegratedTaskRequestTasks self = new UpdateIntegratedTaskRequestTasks();
            return TeaModel.build(map, self);
        }

        public UpdateIntegratedTaskRequestTasks setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public UpdateIntegratedTaskRequestTasks setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public UpdateIntegratedTaskRequestTasks setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

    }

}
