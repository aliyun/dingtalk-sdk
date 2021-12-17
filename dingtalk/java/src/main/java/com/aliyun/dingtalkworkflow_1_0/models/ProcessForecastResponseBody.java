// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ProcessForecastResponseBody extends TeaModel {
    // 返回结果
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

    public static class ProcessForecastResponseBodyResultWorkflowActorsActivityActors extends TeaModel {
        // 用户 id
        @NameInMap("userId")
        public String userId;

        // 用户名字
        @NameInMap("name")
        public String name;

        // 用户头像
        @NameInMap("avatar")
        public String avatar;

        public static ProcessForecastResponseBodyResultWorkflowActorsActivityActors build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastResponseBodyResultWorkflowActorsActivityActors self = new ProcessForecastResponseBodyResultWorkflowActorsActivityActors();
            return TeaModel.build(map, self);
        }

        public ProcessForecastResponseBodyResultWorkflowActorsActivityActors setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ProcessForecastResponseBodyResultWorkflowActorsActivityActors setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ProcessForecastResponseBodyResultWorkflowActorsActivityActors setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

    }

    public static class ProcessForecastResponseBodyResultWorkflowActors extends TeaModel {
        // 节点 id
        @NameInMap("activityId")
        public String activityId;

        // 节点名称
        @NameInMap("activityName")
        public String activityName;

        // 规则类型
        @NameInMap("activityType")
        public String activityType;

        // 是否自选审批节点
        @NameInMap("isTargetSelect")
        public Boolean isTargetSelect;

        @NameInMap("activityActors")
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActorsActivityActors> activityActors;

        // 是否联系人控件审批人节点
        @NameInMap("isTargetFormComponent")
        public Boolean isTargetFormComponent;

        // 节点规则，当前是一个 JSONObject
        @NameInMap("node")
        public String node;

        public static ProcessForecastResponseBodyResultWorkflowActors build(java.util.Map<String, ?> map) throws Exception {
            ProcessForecastResponseBodyResultWorkflowActors self = new ProcessForecastResponseBodyResultWorkflowActors();
            return TeaModel.build(map, self);
        }

        public ProcessForecastResponseBodyResultWorkflowActors setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public ProcessForecastResponseBodyResultWorkflowActors setActivityName(String activityName) {
            this.activityName = activityName;
            return this;
        }
        public String getActivityName() {
            return this.activityName;
        }

        public ProcessForecastResponseBodyResultWorkflowActors setActivityType(String activityType) {
            this.activityType = activityType;
            return this;
        }
        public String getActivityType() {
            return this.activityType;
        }

        public ProcessForecastResponseBodyResultWorkflowActors setIsTargetSelect(Boolean isTargetSelect) {
            this.isTargetSelect = isTargetSelect;
            return this;
        }
        public Boolean getIsTargetSelect() {
            return this.isTargetSelect;
        }

        public ProcessForecastResponseBodyResultWorkflowActors setActivityActors(java.util.List<ProcessForecastResponseBodyResultWorkflowActorsActivityActors> activityActors) {
            this.activityActors = activityActors;
            return this;
        }
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActorsActivityActors> getActivityActors() {
            return this.activityActors;
        }

        public ProcessForecastResponseBodyResultWorkflowActors setIsTargetFormComponent(Boolean isTargetFormComponent) {
            this.isTargetFormComponent = isTargetFormComponent;
            return this;
        }
        public Boolean getIsTargetFormComponent() {
            return this.isTargetFormComponent;
        }

        public ProcessForecastResponseBodyResultWorkflowActors setNode(String node) {
            this.node = node;
            return this;
        }
        public String getNode() {
            return this.node;
        }

    }

    public static class ProcessForecastResponseBodyResultWorkflowForecastNodes extends TeaModel {
        // 节点 id
        @NameInMap("activityId")
        public String activityId;

        // 节点出线 id
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
        // 是否预测成功
        @NameInMap("isForecastSuccess")
        public Boolean isForecastSuccess;

        // 流程 code
        @NameInMap("processCode")
        public String processCode;

        // 用户 id
        @NameInMap("userId")
        public String userId;

        // 流程 id
        @NameInMap("processId")
        public Long processId;

        // 是否静态流程
        @NameInMap("isStaticWorkflow")
        public Boolean isStaticWorkflow;

        @NameInMap("workflowActors")
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActors> workflowActors;

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

        public ProcessForecastResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public ProcessForecastResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ProcessForecastResponseBodyResult setProcessId(Long processId) {
            this.processId = processId;
            return this;
        }
        public Long getProcessId() {
            return this.processId;
        }

        public ProcessForecastResponseBodyResult setIsStaticWorkflow(Boolean isStaticWorkflow) {
            this.isStaticWorkflow = isStaticWorkflow;
            return this;
        }
        public Boolean getIsStaticWorkflow() {
            return this.isStaticWorkflow;
        }

        public ProcessForecastResponseBodyResult setWorkflowActors(java.util.List<ProcessForecastResponseBodyResultWorkflowActors> workflowActors) {
            this.workflowActors = workflowActors;
            return this;
        }
        public java.util.List<ProcessForecastResponseBodyResultWorkflowActors> getWorkflowActors() {
            return this.workflowActors;
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
