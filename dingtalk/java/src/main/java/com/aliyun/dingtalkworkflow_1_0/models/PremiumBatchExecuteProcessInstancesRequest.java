// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumBatchExecuteProcessInstancesRequest extends TeaModel {
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
    public java.util.List<PremiumBatchExecuteProcessInstancesRequestTaskInfoList> taskInfoList;

    public static PremiumBatchExecuteProcessInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumBatchExecuteProcessInstancesRequest self = new PremiumBatchExecuteProcessInstancesRequest();
        return TeaModel.build(map, self);
    }

    public PremiumBatchExecuteProcessInstancesRequest setActionerUserId(String actionerUserId) {
        this.actionerUserId = actionerUserId;
        return this;
    }
    public String getActionerUserId() {
        return this.actionerUserId;
    }

    public PremiumBatchExecuteProcessInstancesRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public PremiumBatchExecuteProcessInstancesRequest setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public PremiumBatchExecuteProcessInstancesRequest setTaskInfoList(java.util.List<PremiumBatchExecuteProcessInstancesRequestTaskInfoList> taskInfoList) {
        this.taskInfoList = taskInfoList;
        return this;
    }
    public java.util.List<PremiumBatchExecuteProcessInstancesRequestTaskInfoList> getTaskInfoList() {
        return this.taskInfoList;
    }

    public static class PremiumBatchExecuteProcessInstancesRequestTaskInfoList extends TeaModel {
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

        public static PremiumBatchExecuteProcessInstancesRequestTaskInfoList build(java.util.Map<String, ?> map) throws Exception {
            PremiumBatchExecuteProcessInstancesRequestTaskInfoList self = new PremiumBatchExecuteProcessInstancesRequestTaskInfoList();
            return TeaModel.build(map, self);
        }

        public PremiumBatchExecuteProcessInstancesRequestTaskInfoList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public PremiumBatchExecuteProcessInstancesRequestTaskInfoList setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

    }

}
