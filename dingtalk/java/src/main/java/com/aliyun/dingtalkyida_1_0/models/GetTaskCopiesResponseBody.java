// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetTaskCopiesResponseBody extends TeaModel {
    /**
     * <p>数据</p>
     */
    @NameInMap("data")
    public java.util.List<GetTaskCopiesResponseBodyData> data;

    /**
     * <p>当前第几页</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>总数量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static GetTaskCopiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTaskCopiesResponseBody self = new GetTaskCopiesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTaskCopiesResponseBody setData(java.util.List<GetTaskCopiesResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetTaskCopiesResponseBodyData> getData() {
        return this.data;
    }

    public GetTaskCopiesResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetTaskCopiesResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetTaskCopiesResponseBodyDataCurrentActivityInstances extends TeaModel {
        /**
         * <p>节点id</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <p>节点实例状态</p>
         */
        @NameInMap("activityInstanceStatus")
        public String activityInstanceStatus;

        /**
         * <p>节点名称</p>
         */
        @NameInMap("activityName")
        public String activityName;

        /**
         * <p>节点英文名称</p>
         */
        @NameInMap("activityNameInEnglish")
        public String activityNameInEnglish;

        /**
         * <p>数据id</p>
         */
        @NameInMap("id")
        public Long id;

        public static GetTaskCopiesResponseBodyDataCurrentActivityInstances build(java.util.Map<String, ?> map) throws Exception {
            GetTaskCopiesResponseBodyDataCurrentActivityInstances self = new GetTaskCopiesResponseBodyDataCurrentActivityInstances();
            return TeaModel.build(map, self);
        }

        public GetTaskCopiesResponseBodyDataCurrentActivityInstances setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetTaskCopiesResponseBodyDataCurrentActivityInstances setActivityInstanceStatus(String activityInstanceStatus) {
            this.activityInstanceStatus = activityInstanceStatus;
            return this;
        }
        public String getActivityInstanceStatus() {
            return this.activityInstanceStatus;
        }

        public GetTaskCopiesResponseBodyDataCurrentActivityInstances setActivityName(String activityName) {
            this.activityName = activityName;
            return this;
        }
        public String getActivityName() {
            return this.activityName;
        }

        public GetTaskCopiesResponseBodyDataCurrentActivityInstances setActivityNameInEnglish(String activityNameInEnglish) {
            this.activityNameInEnglish = activityNameInEnglish;
            return this;
        }
        public String getActivityNameInEnglish() {
            return this.activityNameInEnglish;
        }

        public GetTaskCopiesResponseBodyDataCurrentActivityInstances setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

    }

    public static class GetTaskCopiesResponseBodyData extends TeaModel {
        /**
         * <p>actionerId</p>
         */
        @NameInMap("actionExecutorId")
        public java.util.List<String> actionExecutorId;

        /**
         * <p>actionerName</p>
         */
        @NameInMap("actionExecutorName")
        public java.util.List<String> actionExecutorName;

        /**
         * <p>appType</p>
         */
        @NameInMap("appType")
        public String appType;

        /**
         * <p>carbonActivityId</p>
         */
        @NameInMap("carbonActivityId")
        public String carbonActivityId;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        /**
         * <p>currentActivityInstances</p>
         */
        @NameInMap("currentActivityInstances")
        public java.util.List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> currentActivityInstances;

        /**
         * <p>dataMap</p>
         */
        @NameInMap("dataMap")
        public java.util.Map<String, ?> dataMap;

        /**
         * <p>dataType</p>
         */
        @NameInMap("dataType")
        public String dataType;

        /**
         * <p>结束时间</p>
         */
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        /**
         * <p>formInstanceId</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        /**
         * <p>formUuid</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <p>实例数据</p>
         */
        @NameInMap("instanceValue")
        public String instanceValue;

        /**
         * <p>modifiedTime</p>
         */
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        /**
         * <p>originatorAvatar</p>
         */
        @NameInMap("originatorAvatar")
        public String originatorAvatar;

        /**
         * <p>originatorDisplayName</p>
         */
        @NameInMap("originatorDisplayName")
        public String originatorDisplayName;

        /**
         * <p>originatorId</p>
         */
        @NameInMap("originatorId")
        public String originatorId;

        /**
         * <p>processApprovedResult</p>
         */
        @NameInMap("processApprovedResult")
        public String processApprovedResult;

        /**
         * <p>processApprovedResultText</p>
         */
        @NameInMap("processApprovedResultText")
        public String processApprovedResultText;

        /**
         * <p>processCode</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <p>流程id</p>
         */
        @NameInMap("processId")
        public Long processId;

        /**
         * <p>processInstanceId</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <p>processInstanceStatus</p>
         */
        @NameInMap("processInstanceStatus")
        public String processInstanceStatus;

        /**
         * <p>processInstanceStatusText</p>
         */
        @NameInMap("processInstanceStatusText")
        public String processInstanceStatusText;

        /**
         * <p>processName</p>
         */
        @NameInMap("processName")
        public String processName;

        /**
         * <p>序列号</p>
         */
        @NameInMap("serialNumber")
        public String serialNumber;

        /**
         * <p>标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>版本</p>
         */
        @NameInMap("version")
        public Long version;

        public static GetTaskCopiesResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetTaskCopiesResponseBodyData self = new GetTaskCopiesResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetTaskCopiesResponseBodyData setActionExecutorId(java.util.List<String> actionExecutorId) {
            this.actionExecutorId = actionExecutorId;
            return this;
        }
        public java.util.List<String> getActionExecutorId() {
            return this.actionExecutorId;
        }

        public GetTaskCopiesResponseBodyData setActionExecutorName(java.util.List<String> actionExecutorName) {
            this.actionExecutorName = actionExecutorName;
            return this;
        }
        public java.util.List<String> getActionExecutorName() {
            return this.actionExecutorName;
        }

        public GetTaskCopiesResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetTaskCopiesResponseBodyData setCarbonActivityId(String carbonActivityId) {
            this.carbonActivityId = carbonActivityId;
            return this;
        }
        public String getCarbonActivityId() {
            return this.carbonActivityId;
        }

        public GetTaskCopiesResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetTaskCopiesResponseBodyData setCurrentActivityInstances(java.util.List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> currentActivityInstances) {
            this.currentActivityInstances = currentActivityInstances;
            return this;
        }
        public java.util.List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> getCurrentActivityInstances() {
            return this.currentActivityInstances;
        }

        public GetTaskCopiesResponseBodyData setDataMap(java.util.Map<String, ?> dataMap) {
            this.dataMap = dataMap;
            return this;
        }
        public java.util.Map<String, ?> getDataMap() {
            return this.dataMap;
        }

        public GetTaskCopiesResponseBodyData setDataType(String dataType) {
            this.dataType = dataType;
            return this;
        }
        public String getDataType() {
            return this.dataType;
        }

        public GetTaskCopiesResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetTaskCopiesResponseBodyData setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public GetTaskCopiesResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetTaskCopiesResponseBodyData setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public GetTaskCopiesResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public GetTaskCopiesResponseBodyData setOriginatorAvatar(String originatorAvatar) {
            this.originatorAvatar = originatorAvatar;
            return this;
        }
        public String getOriginatorAvatar() {
            return this.originatorAvatar;
        }

        public GetTaskCopiesResponseBodyData setOriginatorDisplayName(String originatorDisplayName) {
            this.originatorDisplayName = originatorDisplayName;
            return this;
        }
        public String getOriginatorDisplayName() {
            return this.originatorDisplayName;
        }

        public GetTaskCopiesResponseBodyData setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public GetTaskCopiesResponseBodyData setProcessApprovedResult(String processApprovedResult) {
            this.processApprovedResult = processApprovedResult;
            return this;
        }
        public String getProcessApprovedResult() {
            return this.processApprovedResult;
        }

        public GetTaskCopiesResponseBodyData setProcessApprovedResultText(String processApprovedResultText) {
            this.processApprovedResultText = processApprovedResultText;
            return this;
        }
        public String getProcessApprovedResultText() {
            return this.processApprovedResultText;
        }

        public GetTaskCopiesResponseBodyData setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetTaskCopiesResponseBodyData setProcessId(Long processId) {
            this.processId = processId;
            return this;
        }
        public Long getProcessId() {
            return this.processId;
        }

        public GetTaskCopiesResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetTaskCopiesResponseBodyData setProcessInstanceStatus(String processInstanceStatus) {
            this.processInstanceStatus = processInstanceStatus;
            return this;
        }
        public String getProcessInstanceStatus() {
            return this.processInstanceStatus;
        }

        public GetTaskCopiesResponseBodyData setProcessInstanceStatusText(String processInstanceStatusText) {
            this.processInstanceStatusText = processInstanceStatusText;
            return this;
        }
        public String getProcessInstanceStatusText() {
            return this.processInstanceStatusText;
        }

        public GetTaskCopiesResponseBodyData setProcessName(String processName) {
            this.processName = processName;
            return this;
        }
        public String getProcessName() {
            return this.processName;
        }

        public GetTaskCopiesResponseBodyData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public GetTaskCopiesResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetTaskCopiesResponseBodyData setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
