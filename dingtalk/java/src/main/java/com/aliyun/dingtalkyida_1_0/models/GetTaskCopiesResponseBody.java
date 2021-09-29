// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetTaskCopiesResponseBody extends TeaModel {
    // 当前第几页
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 总数量
    @NameInMap("totalCount")
    public Long totalCount;

    // 数据
    @NameInMap("data")
    public java.util.List<GetTaskCopiesResponseBodyData> data;

    public static GetTaskCopiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTaskCopiesResponseBody self = new GetTaskCopiesResponseBody();
        return TeaModel.build(map, self);
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

    public GetTaskCopiesResponseBody setData(java.util.List<GetTaskCopiesResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetTaskCopiesResponseBodyData> getData() {
        return this.data;
    }

    public static class GetTaskCopiesResponseBodyDataCurrentActivityInstances extends TeaModel {
        // 节点名称
        @NameInMap("activityName")
        public String activityName;

        // 节点英文名称
        @NameInMap("activityNameInEnglish")
        public String activityNameInEnglish;

        // 节点id
        @NameInMap("activityId")
        public String activityId;

        // 数据id
        @NameInMap("id")
        public Long id;

        // 节点实例状态
        @NameInMap("activityInstanceStatus")
        public String activityInstanceStatus;

        public static GetTaskCopiesResponseBodyDataCurrentActivityInstances build(java.util.Map<String, ?> map) throws Exception {
            GetTaskCopiesResponseBodyDataCurrentActivityInstances self = new GetTaskCopiesResponseBodyDataCurrentActivityInstances();
            return TeaModel.build(map, self);
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

        public GetTaskCopiesResponseBodyDataCurrentActivityInstances setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetTaskCopiesResponseBodyDataCurrentActivityInstances setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetTaskCopiesResponseBodyDataCurrentActivityInstances setActivityInstanceStatus(String activityInstanceStatus) {
            this.activityInstanceStatus = activityInstanceStatus;
            return this;
        }
        public String getActivityInstanceStatus() {
            return this.activityInstanceStatus;
        }

    }

    public static class GetTaskCopiesResponseBodyData extends TeaModel {
        // actionerId
        @NameInMap("actionExecutorId")
        public java.util.List<String> actionExecutorId;

        // processInstanceId
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // formUuid
        @NameInMap("formUuid")
        public String formUuid;

        // 序列号
        @NameInMap("serialNumber")
        public String serialNumber;

        // processInstanceStatus
        @NameInMap("processInstanceStatus")
        public String processInstanceStatus;

        // originatorDisplayName
        @NameInMap("originatorDisplayName")
        public String originatorDisplayName;

        // modifiedTime
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        // carbonActivityId
        @NameInMap("carbonActivityId")
        public String carbonActivityId;

        // dataType
        @NameInMap("dataType")
        public String dataType;

        // actionerName
        @NameInMap("actionExecutorName")
        public java.util.List<String> actionExecutorName;

        // originatorAvatar
        @NameInMap("originatorAvatar")
        public String originatorAvatar;

        // processInstanceStatusText
        @NameInMap("processInstanceStatusText")
        public String processInstanceStatusText;

        // processApprovedResultText
        @NameInMap("processApprovedResultText")
        public String processApprovedResultText;

        // formInstanceId
        @NameInMap("formInstanceId")
        public String formInstanceId;

        // 标题
        @NameInMap("title")
        public String title;

        // 版本
        @NameInMap("version")
        public Long version;

        // 实例数据
        @NameInMap("instanceValue")
        public String instanceValue;

        // 创建时间
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // processApprovedResult
        @NameInMap("processApprovedResult")
        public String processApprovedResult;

        // 流程id
        @NameInMap("processId")
        public Long processId;

        // processName
        @NameInMap("processName")
        public String processName;

        // processCode
        @NameInMap("processCode")
        public String processCode;

        // appType
        @NameInMap("appType")
        public String appType;

        // dataMap
        @NameInMap("dataMap")
        public java.util.Map<String, ?> dataMap;

        // currentActivityInstances
        @NameInMap("currentActivityInstances")
        public java.util.List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> currentActivityInstances;

        // 结束时间
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        // originatorId
        @NameInMap("originatorId")
        public String originatorId;

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

        public GetTaskCopiesResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetTaskCopiesResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetTaskCopiesResponseBodyData setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public GetTaskCopiesResponseBodyData setProcessInstanceStatus(String processInstanceStatus) {
            this.processInstanceStatus = processInstanceStatus;
            return this;
        }
        public String getProcessInstanceStatus() {
            return this.processInstanceStatus;
        }

        public GetTaskCopiesResponseBodyData setOriginatorDisplayName(String originatorDisplayName) {
            this.originatorDisplayName = originatorDisplayName;
            return this;
        }
        public String getOriginatorDisplayName() {
            return this.originatorDisplayName;
        }

        public GetTaskCopiesResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public GetTaskCopiesResponseBodyData setCarbonActivityId(String carbonActivityId) {
            this.carbonActivityId = carbonActivityId;
            return this;
        }
        public String getCarbonActivityId() {
            return this.carbonActivityId;
        }

        public GetTaskCopiesResponseBodyData setDataType(String dataType) {
            this.dataType = dataType;
            return this;
        }
        public String getDataType() {
            return this.dataType;
        }

        public GetTaskCopiesResponseBodyData setActionExecutorName(java.util.List<String> actionExecutorName) {
            this.actionExecutorName = actionExecutorName;
            return this;
        }
        public java.util.List<String> getActionExecutorName() {
            return this.actionExecutorName;
        }

        public GetTaskCopiesResponseBodyData setOriginatorAvatar(String originatorAvatar) {
            this.originatorAvatar = originatorAvatar;
            return this;
        }
        public String getOriginatorAvatar() {
            return this.originatorAvatar;
        }

        public GetTaskCopiesResponseBodyData setProcessInstanceStatusText(String processInstanceStatusText) {
            this.processInstanceStatusText = processInstanceStatusText;
            return this;
        }
        public String getProcessInstanceStatusText() {
            return this.processInstanceStatusText;
        }

        public GetTaskCopiesResponseBodyData setProcessApprovedResultText(String processApprovedResultText) {
            this.processApprovedResultText = processApprovedResultText;
            return this;
        }
        public String getProcessApprovedResultText() {
            return this.processApprovedResultText;
        }

        public GetTaskCopiesResponseBodyData setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
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

        public GetTaskCopiesResponseBodyData setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public GetTaskCopiesResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetTaskCopiesResponseBodyData setProcessApprovedResult(String processApprovedResult) {
            this.processApprovedResult = processApprovedResult;
            return this;
        }
        public String getProcessApprovedResult() {
            return this.processApprovedResult;
        }

        public GetTaskCopiesResponseBodyData setProcessId(Long processId) {
            this.processId = processId;
            return this;
        }
        public Long getProcessId() {
            return this.processId;
        }

        public GetTaskCopiesResponseBodyData setProcessName(String processName) {
            this.processName = processName;
            return this;
        }
        public String getProcessName() {
            return this.processName;
        }

        public GetTaskCopiesResponseBodyData setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetTaskCopiesResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetTaskCopiesResponseBodyData setDataMap(java.util.Map<String, ?> dataMap) {
            this.dataMap = dataMap;
            return this;
        }
        public java.util.Map<String, ?> getDataMap() {
            return this.dataMap;
        }

        public GetTaskCopiesResponseBodyData setCurrentActivityInstances(java.util.List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> currentActivityInstances) {
            this.currentActivityInstances = currentActivityInstances;
            return this;
        }
        public java.util.List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> getCurrentActivityInstances() {
            return this.currentActivityInstances;
        }

        public GetTaskCopiesResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetTaskCopiesResponseBodyData setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

    }

}
