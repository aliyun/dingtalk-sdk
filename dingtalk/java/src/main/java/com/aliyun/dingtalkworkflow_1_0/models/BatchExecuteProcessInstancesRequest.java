// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchExecuteProcessInstancesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>67583405630</p>
     */
    @NameInMap("actionerUserId")
    public String actionerUserId;

    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>agree</p>
     */
    @NameInMap("result")
    public String result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskInfoList")
    public java.util.List<BatchExecuteProcessInstancesRequestTaskInfoList> taskInfoList;

    public static BatchExecuteProcessInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchExecuteProcessInstancesRequest self = new BatchExecuteProcessInstancesRequest();
        return TeaModel.build(map, self);
    }

    public BatchExecuteProcessInstancesRequest setActionerUserId(String actionerUserId) {
        this.actionerUserId = actionerUserId;
        return this;
    }
    public String getActionerUserId() {
        return this.actionerUserId;
    }

    public BatchExecuteProcessInstancesRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public BatchExecuteProcessInstancesRequest setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public BatchExecuteProcessInstancesRequest setTaskInfoList(java.util.List<BatchExecuteProcessInstancesRequestTaskInfoList> taskInfoList) {
        this.taskInfoList = taskInfoList;
        return this;
    }
    public java.util.List<BatchExecuteProcessInstancesRequestTaskInfoList> getTaskInfoList() {
        return this.taskInfoList;
    }

    public static class BatchExecuteProcessInstancesRequestTaskInfoList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>a171de6c-8bxxxx</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        public static BatchExecuteProcessInstancesRequestTaskInfoList build(java.util.Map<String, ?> map) throws Exception {
            BatchExecuteProcessInstancesRequestTaskInfoList self = new BatchExecuteProcessInstancesRequestTaskInfoList();
            return TeaModel.build(map, self);
        }

        public BatchExecuteProcessInstancesRequestTaskInfoList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public BatchExecuteProcessInstancesRequestTaskInfoList setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

    }

}
