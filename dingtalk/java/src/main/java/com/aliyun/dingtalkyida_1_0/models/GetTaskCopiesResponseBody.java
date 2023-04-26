// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetTaskCopiesResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetTaskCopiesResponseBodyData> data;

    @NameInMap("pageNumber")
    public Long pageNumber;

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
        @NameInMap("activityId")
        public String activityId;

        @NameInMap("activityInstanceStatus")
        public String activityInstanceStatus;

        @NameInMap("activityName")
        public String activityName;

        @NameInMap("activityNameInEnglish")
        public String activityNameInEnglish;

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
        @NameInMap("actionExecutorId")
        public java.util.List<String> actionExecutorId;

        @NameInMap("actionExecutorName")
        public java.util.List<String> actionExecutorName;

        @NameInMap("appType")
        public String appType;

        @NameInMap("carbonActivityId")
        public String carbonActivityId;

        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        @NameInMap("currentActivityInstances")
        public java.util.List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> currentActivityInstances;

        @NameInMap("dataMap")
        public java.util.Map<String, ?> dataMap;

        @NameInMap("dataType")
        public String dataType;

        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("formInstanceId")
        public String formInstanceId;

        @NameInMap("formUuid")
        public String formUuid;

        @NameInMap("instanceValue")
        public String instanceValue;

        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        @NameInMap("originatorAvatar")
        public String originatorAvatar;

        @NameInMap("originatorDisplayName")
        public String originatorDisplayName;

        @NameInMap("originatorId")
        public String originatorId;

        @NameInMap("processApprovedResult")
        public String processApprovedResult;

        @NameInMap("processApprovedResultText")
        public String processApprovedResultText;

        @NameInMap("processCode")
        public String processCode;

        @NameInMap("processId")
        public Long processId;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("processInstanceStatus")
        public String processInstanceStatus;

        @NameInMap("processInstanceStatusText")
        public String processInstanceStatusText;

        @NameInMap("processName")
        public String processName;

        @NameInMap("serialNumber")
        public String serialNumber;

        @NameInMap("title")
        public String title;

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
