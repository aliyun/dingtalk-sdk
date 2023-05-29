// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessInstanceResponseBody extends TeaModel {
    @NameInMap("result")
    public GetProcessInstanceResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static GetProcessInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProcessInstanceResponseBody self = new GetProcessInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProcessInstanceResponseBody setResult(GetProcessInstanceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetProcessInstanceResponseBodyResult getResult() {
        return this.result;
    }

    public GetProcessInstanceResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class GetProcessInstanceResponseBodyResultFormComponentValues extends TeaModel {
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("extValue")
        public String extValue;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static GetProcessInstanceResponseBodyResultFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceResponseBodyResultFormComponentValues self = new GetProcessInstanceResponseBodyResultFormComponentValues();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceResponseBodyResultFormComponentValues setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public GetProcessInstanceResponseBodyResultFormComponentValues setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public GetProcessInstanceResponseBodyResultFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public GetProcessInstanceResponseBodyResultFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetProcessInstanceResponseBodyResultFormComponentValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetProcessInstanceResponseBodyResultFormComponentValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetProcessInstanceResponseBodyResultOperationRecordsAttachments extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public String fileSize;

        @NameInMap("fileType")
        public String fileType;

        public static GetProcessInstanceResponseBodyResultOperationRecordsAttachments build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceResponseBodyResultOperationRecordsAttachments self = new GetProcessInstanceResponseBodyResultOperationRecordsAttachments();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceResponseBodyResultOperationRecordsAttachments setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetProcessInstanceResponseBodyResultOperationRecordsAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetProcessInstanceResponseBodyResultOperationRecordsAttachments setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public GetProcessInstanceResponseBodyResultOperationRecordsAttachments setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

    }

    public static class GetProcessInstanceResponseBodyResultOperationRecords extends TeaModel {
        @NameInMap("attachments")
        public java.util.List<GetProcessInstanceResponseBodyResultOperationRecordsAttachments> attachments;

        @NameInMap("ccUserIds")
        public java.util.List<String> ccUserIds;

        @NameInMap("date")
        public String date;

        @NameInMap("remark")
        public String remark;

        @NameInMap("result")
        public String result;

        @NameInMap("type")
        public String type;

        @NameInMap("userId")
        public String userId;

        public static GetProcessInstanceResponseBodyResultOperationRecords build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceResponseBodyResultOperationRecords self = new GetProcessInstanceResponseBodyResultOperationRecords();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceResponseBodyResultOperationRecords setAttachments(java.util.List<GetProcessInstanceResponseBodyResultOperationRecordsAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<GetProcessInstanceResponseBodyResultOperationRecordsAttachments> getAttachments() {
            return this.attachments;
        }

        public GetProcessInstanceResponseBodyResultOperationRecords setCcUserIds(java.util.List<String> ccUserIds) {
            this.ccUserIds = ccUserIds;
            return this;
        }
        public java.util.List<String> getCcUserIds() {
            return this.ccUserIds;
        }

        public GetProcessInstanceResponseBodyResultOperationRecords setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public GetProcessInstanceResponseBodyResultOperationRecords setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetProcessInstanceResponseBodyResultOperationRecords setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public GetProcessInstanceResponseBodyResultOperationRecords setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetProcessInstanceResponseBodyResultOperationRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetProcessInstanceResponseBodyResultTasks extends TeaModel {
        @NameInMap("activityId")
        public String activityId;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("finishTime")
        public String finishTime;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("result")
        public String result;

        @NameInMap("status")
        public String status;

        @NameInMap("taskId")
        public Long taskId;

        @NameInMap("userId")
        public String userId;

        public static GetProcessInstanceResponseBodyResultTasks build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceResponseBodyResultTasks self = new GetProcessInstanceResponseBodyResultTasks();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceResponseBodyResultTasks setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetProcessInstanceResponseBodyResultTasks setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetProcessInstanceResponseBodyResultTasks setFinishTime(String finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public String getFinishTime() {
            return this.finishTime;
        }

        public GetProcessInstanceResponseBodyResultTasks setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public GetProcessInstanceResponseBodyResultTasks setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetProcessInstanceResponseBodyResultTasks setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetProcessInstanceResponseBodyResultTasks setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public GetProcessInstanceResponseBodyResultTasks setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetProcessInstanceResponseBodyResultTasks setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public GetProcessInstanceResponseBodyResultTasks setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetProcessInstanceResponseBodyResult extends TeaModel {
        @NameInMap("approverUserIds")
        public java.util.List<String> approverUserIds;

        @NameInMap("attachedProcessInstanceIds")
        public java.util.List<String> attachedProcessInstanceIds;

        @NameInMap("bizAction")
        public String bizAction;

        @NameInMap("bizData")
        public String bizData;

        @NameInMap("businessId")
        public String businessId;

        @NameInMap("ccUserIds")
        public java.util.List<String> ccUserIds;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("finishTime")
        public String finishTime;

        @NameInMap("formComponentValues")
        public java.util.List<GetProcessInstanceResponseBodyResultFormComponentValues> formComponentValues;

        @NameInMap("mainProcessInstanceId")
        public String mainProcessInstanceId;

        @NameInMap("operationRecords")
        public java.util.List<GetProcessInstanceResponseBodyResultOperationRecords> operationRecords;

        @NameInMap("originatorDeptId")
        public String originatorDeptId;

        @NameInMap("originatorDeptName")
        public String originatorDeptName;

        @NameInMap("originatorUserId")
        public String originatorUserId;

        @NameInMap("result")
        public String result;

        @NameInMap("status")
        public String status;

        @NameInMap("tasks")
        public java.util.List<GetProcessInstanceResponseBodyResultTasks> tasks;

        @NameInMap("title")
        public String title;

        public static GetProcessInstanceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceResponseBodyResult self = new GetProcessInstanceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceResponseBodyResult setApproverUserIds(java.util.List<String> approverUserIds) {
            this.approverUserIds = approverUserIds;
            return this;
        }
        public java.util.List<String> getApproverUserIds() {
            return this.approverUserIds;
        }

        public GetProcessInstanceResponseBodyResult setAttachedProcessInstanceIds(java.util.List<String> attachedProcessInstanceIds) {
            this.attachedProcessInstanceIds = attachedProcessInstanceIds;
            return this;
        }
        public java.util.List<String> getAttachedProcessInstanceIds() {
            return this.attachedProcessInstanceIds;
        }

        public GetProcessInstanceResponseBodyResult setBizAction(String bizAction) {
            this.bizAction = bizAction;
            return this;
        }
        public String getBizAction() {
            return this.bizAction;
        }

        public GetProcessInstanceResponseBodyResult setBizData(String bizData) {
            this.bizData = bizData;
            return this;
        }
        public String getBizData() {
            return this.bizData;
        }

        public GetProcessInstanceResponseBodyResult setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public GetProcessInstanceResponseBodyResult setCcUserIds(java.util.List<String> ccUserIds) {
            this.ccUserIds = ccUserIds;
            return this;
        }
        public java.util.List<String> getCcUserIds() {
            return this.ccUserIds;
        }

        public GetProcessInstanceResponseBodyResult setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetProcessInstanceResponseBodyResult setFinishTime(String finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public String getFinishTime() {
            return this.finishTime;
        }

        public GetProcessInstanceResponseBodyResult setFormComponentValues(java.util.List<GetProcessInstanceResponseBodyResultFormComponentValues> formComponentValues) {
            this.formComponentValues = formComponentValues;
            return this;
        }
        public java.util.List<GetProcessInstanceResponseBodyResultFormComponentValues> getFormComponentValues() {
            return this.formComponentValues;
        }

        public GetProcessInstanceResponseBodyResult setMainProcessInstanceId(String mainProcessInstanceId) {
            this.mainProcessInstanceId = mainProcessInstanceId;
            return this;
        }
        public String getMainProcessInstanceId() {
            return this.mainProcessInstanceId;
        }

        public GetProcessInstanceResponseBodyResult setOperationRecords(java.util.List<GetProcessInstanceResponseBodyResultOperationRecords> operationRecords) {
            this.operationRecords = operationRecords;
            return this;
        }
        public java.util.List<GetProcessInstanceResponseBodyResultOperationRecords> getOperationRecords() {
            return this.operationRecords;
        }

        public GetProcessInstanceResponseBodyResult setOriginatorDeptId(String originatorDeptId) {
            this.originatorDeptId = originatorDeptId;
            return this;
        }
        public String getOriginatorDeptId() {
            return this.originatorDeptId;
        }

        public GetProcessInstanceResponseBodyResult setOriginatorDeptName(String originatorDeptName) {
            this.originatorDeptName = originatorDeptName;
            return this;
        }
        public String getOriginatorDeptName() {
            return this.originatorDeptName;
        }

        public GetProcessInstanceResponseBodyResult setOriginatorUserId(String originatorUserId) {
            this.originatorUserId = originatorUserId;
            return this;
        }
        public String getOriginatorUserId() {
            return this.originatorUserId;
        }

        public GetProcessInstanceResponseBodyResult setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public GetProcessInstanceResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetProcessInstanceResponseBodyResult setTasks(java.util.List<GetProcessInstanceResponseBodyResultTasks> tasks) {
            this.tasks = tasks;
            return this;
        }
        public java.util.List<GetProcessInstanceResponseBodyResultTasks> getTasks() {
            return this.tasks;
        }

        public GetProcessInstanceResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
