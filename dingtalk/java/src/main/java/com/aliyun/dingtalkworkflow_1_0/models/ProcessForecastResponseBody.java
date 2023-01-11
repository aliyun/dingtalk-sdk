// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ProcessForecastResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     */
    @NameInMap("result")
    public ProcessForecastResponseBodyResult result;

    public static ProcessForecastResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ProcessForecastResponseBody self = new ProcessForecastResponseBody();
        return TeaModel.build(map, self);
    }

    public ProcessForecastResponseBody setResult(ProcessForecastResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ProcessForecastResponseBodyResult getResult() {
        return this.result;
    }

    public static class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals extends TeaModel {
        /**
         * <p>员工姓名</p>
         */
        @NameInMap("userName")
        public String userName;

        /**
         * <p>员工 userId</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals self = new ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals();
            return TeaModel.build(map, self);
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

    public static class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels extends TeaModel {
        /**
         * <p>角色名字</p>
         */
        @NameInMap("labelNames")
        public String labelNames;

        /**
         * <p>角色 id</p>
         */
        @NameInMap("labels")
        public String labels;

        public static ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels self = new ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels();
            return TeaModel.build(map, self);
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels setLabelNames(String labelNames) {
            this.labelNames = labelNames;
            return this;
        }
        public String getLabelNames() {
            return this.labelNames;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels setLabels(String labels) {
            this.labels = labels;
            return this;
        }
        public String getLabels() {
            return this.labels;
        }

    }

    public static class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange extends TeaModel {
        /**
         * <p>审批指定成员</p>
         */
        @NameInMap("approvals")
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals> approvals;

        /**
         * <p>审批指定角色</p>
         */
        @NameInMap("labels")
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels> labels;

        public static ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange self = new ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange();
            return TeaModel.build(map, self);
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange setApprovals(java.util.List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals> approvals) {
            this.approvals = approvals;
            return this;
        }
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals> getApprovals() {
            return this.approvals;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange setLabels(java.util.List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels> labels) {
            this.labels = labels;
            return this;
        }
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels> getLabels() {
            return this.labels;
        }

    }

    public static class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor extends TeaModel {
        /**
         * <p>节点激活类型</p>
         */
        @NameInMap("actorActivateType")
        public String actorActivateType;

        /**
         * <p>节点操作人 key</p>
         */
        @NameInMap("actorKey")
        public String actorKey;

        /**
         * <p>节点操作人选择范围</p>
         */
        @NameInMap("actorSelectionRange")
        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange actorSelectionRange;

        /**
         * <p>节点操作人选择范围类型</p>
         */
        @NameInMap("actorSelectionType")
        public String actorSelectionType;

        /**
         * <p>节点操作人类型</p>
         */
        @NameInMap("actorType")
        public String actorType;

        /**
         * <p>是否允许多选，还是仅允许选一人</p>
         */
        @NameInMap("allowedMulti")
        public Boolean allowedMulti;

        /**
         * <p>节点审批方式</p>
         */
        @NameInMap("approvalMethod")
        public String approvalMethod;

        /**
         * <p>节点审批类型</p>
         */
        @NameInMap("approvalType")
        public String approvalType;

        /**
         * <p>该审批人节点在发起审批时是否必填</p>
         */
        @NameInMap("required")
        public Boolean required;

        public static ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor self = new ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor();
            return TeaModel.build(map, self);
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor setActorActivateType(String actorActivateType) {
            this.actorActivateType = actorActivateType;
            return this;
        }
        public String getActorActivateType() {
            return this.actorActivateType;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor setActorKey(String actorKey) {
            this.actorKey = actorKey;
            return this;
        }
        public String getActorKey() {
            return this.actorKey;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor setActorSelectionRange(ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange actorSelectionRange) {
            this.actorSelectionRange = actorSelectionRange;
            return this;
        }
        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange getActorSelectionRange() {
            return this.actorSelectionRange;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor setActorSelectionType(String actorSelectionType) {
            this.actorSelectionType = actorSelectionType;
            return this;
        }
        public String getActorSelectionType() {
            return this.actorSelectionType;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor setActorType(String actorType) {
            this.actorType = actorType;
            return this;
        }
        public String getActorType() {
            return this.actorType;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor setAllowedMulti(Boolean allowedMulti) {
            this.allowedMulti = allowedMulti;
            return this;
        }
        public Boolean getAllowedMulti() {
            return this.allowedMulti;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor setApprovalMethod(String approvalMethod) {
            this.approvalMethod = approvalMethod;
            return this;
        }
        public String getApprovalMethod() {
            return this.approvalMethod;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor setApprovalType(String approvalType) {
            this.approvalType = approvalType;
            return this;
        }
        public String getApprovalType() {
            return this.approvalType;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

    }

    public static class ProcessForecastResponseBodyResultWorkflowActivityRules extends TeaModel {
        /**
         * <p>节点 id</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <p>节点名称</p>
         */
        @NameInMap("activityName")
        public String activityName;

        /**
         * <p>规则类型</p>
         */
        @NameInMap("activityType")
        public String activityType;

        /**
         * <p>是否自选审批节点</p>
         */
        @NameInMap("isTargetSelect")
        public Boolean isTargetSelect;

        /**
         * <p>流程中前一个节点的 id</p>
         */
        @NameInMap("prevActivityId")
        public String prevActivityId;

        /**
         * <p>节点操作人信息</p>
         */
        @NameInMap("workflowActor")
        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor workflowActor;

        public static ProcessForecastResponseBodyResultWorkflowActivityRules build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastResponseBodyResultWorkflowActivityRules self = new ProcessForecastResponseBodyResultWorkflowActivityRules();
            return TeaModel.build(map, self);
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRules setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRules setActivityName(String activityName) {
            this.activityName = activityName;
            return this;
        }
        public String getActivityName() {
            return this.activityName;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRules setActivityType(String activityType) {
            this.activityType = activityType;
            return this;
        }
        public String getActivityType() {
            return this.activityType;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRules setIsTargetSelect(Boolean isTargetSelect) {
            this.isTargetSelect = isTargetSelect;
            return this;
        }
        public Boolean getIsTargetSelect() {
            return this.isTargetSelect;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRules setPrevActivityId(String prevActivityId) {
            this.prevActivityId = prevActivityId;
            return this;
        }
        public String getPrevActivityId() {
            return this.prevActivityId;
        }

        public ProcessForecastResponseBodyResultWorkflowActivityRules setWorkflowActor(ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor workflowActor) {
            this.workflowActor = workflowActor;
            return this;
        }
        public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor getWorkflowActor() {
            return this.workflowActor;
        }

    }

    public static class ProcessForecastResponseBodyResultWorkflowForecastNodes extends TeaModel {
        /**
         * <p>节点 id</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <p>节点出线 id</p>
         */
        @NameInMap("outId")
        public String outId;

        public static ProcessForecastResponseBodyResultWorkflowForecastNodes build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastResponseBodyResultWorkflowForecastNodes self = new ProcessForecastResponseBodyResultWorkflowForecastNodes();
            return TeaModel.build(map, self);
        }

        public ProcessForecastResponseBodyResultWorkflowForecastNodes setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public ProcessForecastResponseBodyResultWorkflowForecastNodes setOutId(String outId) {
            this.outId = outId;
            return this;
        }
        public String getOutId() {
            return this.outId;
        }

    }

    public static class ProcessForecastResponseBodyResult extends TeaModel {
        /**
         * <p>是否预测成功</p>
         */
        @NameInMap("isForecastSuccess")
        public Boolean isForecastSuccess;

        /**
         * <p>是否静态流程</p>
         */
        @NameInMap("isStaticWorkflow")
        public Boolean isStaticWorkflow;

        /**
         * <p>流程 code</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <p>流程 id</p>
         */
        @NameInMap("processId")
        public Long processId;

        /**
         * <p>用户 id</p>
         */
        @NameInMap("userId")
        public String userId;

        @NameInMap("workflowActivityRules")
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActivityRules> workflowActivityRules;

        @NameInMap("workflowForecastNodes")
        public java.util.List<ProcessForecastResponseBodyResultWorkflowForecastNodes> workflowForecastNodes;

        public static ProcessForecastResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastResponseBodyResult self = new ProcessForecastResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ProcessForecastResponseBodyResult setIsForecastSuccess(Boolean isForecastSuccess) {
            this.isForecastSuccess = isForecastSuccess;
            return this;
        }
        public Boolean getIsForecastSuccess() {
            return this.isForecastSuccess;
        }

        public ProcessForecastResponseBodyResult setIsStaticWorkflow(Boolean isStaticWorkflow) {
            this.isStaticWorkflow = isStaticWorkflow;
            return this;
        }
        public Boolean getIsStaticWorkflow() {
            return this.isStaticWorkflow;
        }

        public ProcessForecastResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public ProcessForecastResponseBodyResult setProcessId(Long processId) {
            this.processId = processId;
            return this;
        }
        public Long getProcessId() {
            return this.processId;
        }

        public ProcessForecastResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ProcessForecastResponseBodyResult setWorkflowActivityRules(java.util.List<ProcessForecastResponseBodyResultWorkflowActivityRules> workflowActivityRules) {
            this.workflowActivityRules = workflowActivityRules;
            return this;
        }
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActivityRules> getWorkflowActivityRules() {
            return this.workflowActivityRules;
        }

        public ProcessForecastResponseBodyResult setWorkflowForecastNodes(java.util.List<ProcessForecastResponseBodyResultWorkflowForecastNodes> workflowForecastNodes) {
            this.workflowForecastNodes = workflowForecastNodes;
            return this;
        }
        public java.util.List<ProcessForecastResponseBodyResultWorkflowForecastNodes> getWorkflowForecastNodes() {
            return this.workflowForecastNodes;
        }

    }

}
