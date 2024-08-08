// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessInstanceWithExtraResponseBody extends TeaModel {
    @NameInMap("result")
    public GetProcessInstanceWithExtraResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public String success;

    public static GetProcessInstanceWithExtraResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProcessInstanceWithExtraResponseBody self = new GetProcessInstanceWithExtraResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProcessInstanceWithExtraResponseBody setResult(GetProcessInstanceWithExtraResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetProcessInstanceWithExtraResponseBodyResult getResult() {
        return this.result;
    }

    public GetProcessInstanceWithExtraResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class GetProcessInstanceWithExtraResponseBodyResultFormComponentValues extends TeaModel {
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("extValue")
        public String extValue;

        /**
         * <strong>example:</strong>
         * <p>DDHolidayField-J2Bxxxx</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>组件1</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static GetProcessInstanceWithExtraResponseBodyResultFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceWithExtraResponseBodyResultFormComponentValues self = new GetProcessInstanceWithExtraResponseBodyResultFormComponentValues();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceWithExtraResponseBodyResultFormComponentValues setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public GetProcessInstanceWithExtraResponseBodyResultFormComponentValues setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public GetProcessInstanceWithExtraResponseBodyResultFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public GetProcessInstanceWithExtraResponseBodyResultFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetProcessInstanceWithExtraResponseBodyResultFormComponentValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetProcessInstanceWithExtraResponseBodyResultFormComponentValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <strong>example:</strong>
         * <p>学历证明</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>50000</p>
         */
        @NameInMap("fileSize")
        public String fileSize;

        /**
         * <strong>example:</strong>
         * <p>.pdf</p>
         */
        @NameInMap("fileType")
        public String fileType;

        /**
         * <strong>example:</strong>
         * <p>158469</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        public static GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments self = new GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class GetProcessInstanceWithExtraResponseBodyResultOperationRecords extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>aacc_ddee</p>
         */
        @NameInMap("activityId")
        public String activityId;

        @NameInMap("attachments")
        public java.util.List<GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments> attachments;

        @NameInMap("ccUserIds")
        public java.util.List<String> ccUserIds;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2022-08-31T11:52Z</p>
         */
        @NameInMap("date")
        public String date;

        /**
         * <strong>example:</strong>
         * <p>AzBltRlvKukX3WsbLxpDnTZskRNK5GtVfuDlDQ_Qxsp</p>
         */
        @NameInMap("handSignToken")
        public String handSignToken;

        @NameInMap("images")
        public java.util.List<String> images;

        @NameInMap("remark")
        public String remark;

        /**
         * <strong>example:</strong>
         * <p>AGREE</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <strong>example:</strong>
         * <p>审批人节点</p>
         */
        @NameInMap("showName")
        public String showName;

        /**
         * <strong>example:</strong>
         * <p>EXECUTE_TASK_NORMAL</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>manager123</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetProcessInstanceWithExtraResponseBodyResultOperationRecords build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceWithExtraResponseBodyResultOperationRecords self = new GetProcessInstanceWithExtraResponseBodyResultOperationRecords();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setAttachments(java.util.List<GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<GetProcessInstanceWithExtraResponseBodyResultOperationRecordsAttachments> getAttachments() {
            return this.attachments;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setCcUserIds(java.util.List<String> ccUserIds) {
            this.ccUserIds = ccUserIds;
            return this;
        }
        public java.util.List<String> getCcUserIds() {
            return this.ccUserIds;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setHandSignToken(String handSignToken) {
            this.handSignToken = handSignToken;
            return this;
        }
        public String getHandSignToken() {
            return this.handSignToken;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setImages(java.util.List<String> images) {
            this.images = images;
            return this;
        }
        public java.util.List<String> getImages() {
            return this.images;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setShowName(String showName) {
            this.showName = showName;
            return this;
        }
        public String getShowName() {
            return this.showName;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetProcessInstanceWithExtraResponseBodyResultOperationRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetProcessInstanceWithExtraResponseBodyResultTasks extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>aabb_ccdd</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2024-06-12T14:17Z</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2024-06-12T14:17Z</p>
         */
        @NameInMap("finishTime")
        public String finishTime;

        /**
         * <strong>example:</strong>
         * <p>aflow.dingtalk.com?procInsId=lTGxxx</p>
         */
        @NameInMap("mobileUrl")
        public String mobileUrl;

        /**
         * <strong>example:</strong>
         * <p>aflow.dingtalk.com?procInsId=lTGxxx</p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        /**
         * <strong>example:</strong>
         * <p>fewferxxxx</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>REDIRECTED</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <strong>example:</strong>
         * <p>CANCELED</p>
         */
        @NameInMap("status")
        public String status;

        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>manager123</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetProcessInstanceWithExtraResponseBodyResultTasks build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceWithExtraResponseBodyResultTasks self = new GetProcessInstanceWithExtraResponseBodyResultTasks();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setFinishTime(String finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public String getFinishTime() {
            return this.finishTime;
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public GetProcessInstanceWithExtraResponseBodyResultTasks setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetProcessInstanceWithExtraResponseBodyResult extends TeaModel {
        @NameInMap("approverUserIds")
        public java.util.List<String> approverUserIds;

        @NameInMap("attachedProcessInstanceIds")
        public java.util.List<String> attachedProcessInstanceIds;

        /**
         * <strong>example:</strong>
         * <p>MODIFY</p>
         */
        @NameInMap("bizAction")
        public String bizAction;

        @NameInMap("bizData")
        public String bizData;

        /**
         * <strong>example:</strong>
         * <p>20240505xxxx</p>
         */
        @NameInMap("businessId")
        public String businessId;

        @NameInMap("ccUserIds")
        public java.util.List<String> ccUserIds;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2022-08-31T11:52Z</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>2022-08-31T11:52Z</p>
         */
        @NameInMap("finishTime")
        public String finishTime;

        @NameInMap("formComponentValues")
        public java.util.List<GetProcessInstanceWithExtraResponseBodyResultFormComponentValues> formComponentValues;

        /**
         * <strong>example:</strong>
         * <p>fvdsfxxxxxx</p>
         */
        @NameInMap("mainProcessInstanceId")
        public String mainProcessInstanceId;

        @NameInMap("operationRecords")
        public java.util.List<GetProcessInstanceWithExtraResponseBodyResultOperationRecords> operationRecords;

        /**
         * <strong>example:</strong>
         * <p>25489</p>
         */
        @NameInMap("originatorDeptId")
        public String originatorDeptId;

        /**
         * <strong>example:</strong>
         * <p>测试部门</p>
         */
        @NameInMap("originatorDeptName")
        public String originatorDeptName;

        /**
         * <strong>example:</strong>
         * <p>manager1</p>
         */
        @NameInMap("originatorUserId")
        public String originatorUserId;

        /**
         * <strong>example:</strong>
         * <p>agree</p>
         */
        @NameInMap("result")
        public String result;

        @NameInMap("status")
        public String status;

        @NameInMap("tasks")
        public java.util.List<GetProcessInstanceWithExtraResponseBodyResultTasks> tasks;

        /**
         * <strong>example:</strong>
         * <p>xx提交的请假申请</p>
         */
        @NameInMap("title")
        public String title;

        public static GetProcessInstanceWithExtraResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProcessInstanceWithExtraResponseBodyResult self = new GetProcessInstanceWithExtraResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProcessInstanceWithExtraResponseBodyResult setApproverUserIds(java.util.List<String> approverUserIds) {
            this.approverUserIds = approverUserIds;
            return this;
        }
        public java.util.List<String> getApproverUserIds() {
            return this.approverUserIds;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setAttachedProcessInstanceIds(java.util.List<String> attachedProcessInstanceIds) {
            this.attachedProcessInstanceIds = attachedProcessInstanceIds;
            return this;
        }
        public java.util.List<String> getAttachedProcessInstanceIds() {
            return this.attachedProcessInstanceIds;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setBizAction(String bizAction) {
            this.bizAction = bizAction;
            return this;
        }
        public String getBizAction() {
            return this.bizAction;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setBizData(String bizData) {
            this.bizData = bizData;
            return this;
        }
        public String getBizData() {
            return this.bizData;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setCcUserIds(java.util.List<String> ccUserIds) {
            this.ccUserIds = ccUserIds;
            return this;
        }
        public java.util.List<String> getCcUserIds() {
            return this.ccUserIds;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setFinishTime(String finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public String getFinishTime() {
            return this.finishTime;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setFormComponentValues(java.util.List<GetProcessInstanceWithExtraResponseBodyResultFormComponentValues> formComponentValues) {
            this.formComponentValues = formComponentValues;
            return this;
        }
        public java.util.List<GetProcessInstanceWithExtraResponseBodyResultFormComponentValues> getFormComponentValues() {
            return this.formComponentValues;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setMainProcessInstanceId(String mainProcessInstanceId) {
            this.mainProcessInstanceId = mainProcessInstanceId;
            return this;
        }
        public String getMainProcessInstanceId() {
            return this.mainProcessInstanceId;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setOperationRecords(java.util.List<GetProcessInstanceWithExtraResponseBodyResultOperationRecords> operationRecords) {
            this.operationRecords = operationRecords;
            return this;
        }
        public java.util.List<GetProcessInstanceWithExtraResponseBodyResultOperationRecords> getOperationRecords() {
            return this.operationRecords;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setOriginatorDeptId(String originatorDeptId) {
            this.originatorDeptId = originatorDeptId;
            return this;
        }
        public String getOriginatorDeptId() {
            return this.originatorDeptId;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setOriginatorDeptName(String originatorDeptName) {
            this.originatorDeptName = originatorDeptName;
            return this;
        }
        public String getOriginatorDeptName() {
            return this.originatorDeptName;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setOriginatorUserId(String originatorUserId) {
            this.originatorUserId = originatorUserId;
            return this;
        }
        public String getOriginatorUserId() {
            return this.originatorUserId;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setTasks(java.util.List<GetProcessInstanceWithExtraResponseBodyResultTasks> tasks) {
            this.tasks = tasks;
            return this;
        }
        public java.util.List<GetProcessInstanceWithExtraResponseBodyResultTasks> getTasks() {
            return this.tasks;
        }

        public GetProcessInstanceWithExtraResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
