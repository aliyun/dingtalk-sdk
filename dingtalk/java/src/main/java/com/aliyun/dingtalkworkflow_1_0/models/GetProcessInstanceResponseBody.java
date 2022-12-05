// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessInstanceResponseBody extends TeaModel {
    // 返回结果。
    @NameInMap("result")
    public GetProcessInstanceResponseBodyResult result;

    // 调用是否成功。
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
        // 组件别名。
        @NameInMap("bizAlias")
        public String bizAlias;

        // 组件类型。
        @NameInMap("componentType")
        public String componentType;

        // 标签扩展值。
        @NameInMap("extValue")
        public String extValue;

        // 组件ID。
        @NameInMap("id")
        public String id;

        // 组件名称。
        @NameInMap("name")
        public String name;

        // 标签值。
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
        // 附件ID。
        @NameInMap("fileId")
        public String fileId;

        // 附件名称。
        @NameInMap("fileName")
        public String fileName;

        // 附件大小。
        @NameInMap("fileSize")
        public String fileSize;

        // 附件类型。
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
        // 评论附件列表。
        @NameInMap("attachments")
        public java.util.List<GetProcessInstanceResponseBodyResultOperationRecordsAttachments> attachments;

        // 抄送人userIds列表
        @NameInMap("ccUserIds")
        public java.util.List<String> ccUserIds;

        // 操作时间。
        @NameInMap("date")
        public String date;

        // 评论内容。  审批操作附带评论时才返回该字段。
        @NameInMap("remark")
        public String remark;

        // 操作结果：  AGREE：同意  REFUSE：拒绝  NONE
        @NameInMap("result")
        public String result;

        // 操作类型：  EXECUTE_TASK_NORMAL：正常执行任务  EXECUTE_TASK_AGENT：代理人执行任务  APPEND_TASK_BEFORE：前加签任务  APPEND_TASK_AFTER：后加签任务  REDIRECT_TASK：转交任务  START_PROCESS_INSTANCE：发起流程实例  TERMINATE_PROCESS_INSTANCE：终止(撤销)流程实例  FINISH_PROCESS_INSTANCE：结束流程实例  ADD_REMARK：添加评论  REDIRECT_PROCESS：审批退回  PROCESS_CC：抄送
        @NameInMap("type")
        public String type;

        // 操作人userid。
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
        // 任务节点ID。
        @NameInMap("activityId")
        public String activityId;

        // 开始时间。
        @NameInMap("createTime")
        public String createTime;

        // 结束时间。
        @NameInMap("finishTime")
        public String finishTime;

        // 移动端任务URL。
        @NameInMap("mobileUrl")
        public String mobileUrl;

        // PC端任务URL。
        @NameInMap("pcUrl")
        public String pcUrl;

        // 实例ID。
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // 结果：  AGREE：同意  REFUSE：拒绝  REDIRECTED：转交
        @NameInMap("result")
        public String result;

        // 任务状态：  NEW：未启动  RUNNING：处理中  PAUSED：暂停  CANCELED：取消  COMPLETED：完成  TERMINATED：终止
        @NameInMap("status")
        public String status;

        // 任务ID。
        @NameInMap("taskId")
        public Long taskId;

        // 任务处理人。
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
        // 审批人userid列表。
        @NameInMap("approverUserIds")
        public java.util.List<String> approverUserIds;

        // 审批附属实例列表，当已经通过的审批实例被修改或撤销，会生成一个新的实例，作为原有审批实例的附属。  如果想知道当前已经通过的审批实例的状态，可以依次遍历它的附属列表，查询里面每个实例的biz_action。
        @NameInMap("attachedProcessInstanceIds")
        public java.util.List<String> attachedProcessInstanceIds;

        // 审批实例业务动作：  MODIFY：表示该审批实例是基于原来的实例修改而来  REVOKE：表示该审批实例是由原来的实例撤销后重新发起的  NONE表示正常发起
        @NameInMap("bizAction")
        public String bizAction;

        // 审批实例业务编号。
        @NameInMap("businessId")
        public String businessId;

        // 抄送人userid列表。
        @NameInMap("ccUserIds")
        public java.util.List<String> ccUserIds;

        // 创建时间。
        @NameInMap("createTime")
        public String createTime;

        // 结束时间。
        @NameInMap("finishTime")
        public String finishTime;

        // 表单详情列表。
        @NameInMap("formComponentValues")
        public java.util.List<GetProcessInstanceResponseBodyResultFormComponentValues> formComponentValues;

        // 主流程实例标识。
        @NameInMap("mainProcessInstanceId")
        public String mainProcessInstanceId;

        // 操作记录列表。
        @NameInMap("operationRecords")
        public java.util.List<GetProcessInstanceResponseBodyResultOperationRecords> operationRecords;

        // 发起人的部门。-1表示根部门。
        @NameInMap("originatorDeptId")
        public String originatorDeptId;

        // 发起人的部门名。
        @NameInMap("originatorDeptName")
        public String originatorDeptName;

        // 发起人的userid。
        @NameInMap("originatorUserId")
        public String originatorUserId;

        // 审批结果：  agree：同意  refuse：拒绝。 说明 status为COMPLETED且result为同意时，表示审批单完结并审批通过。
        @NameInMap("result")
        public String result;

        // 审批状态：  NEW：新创建  RUNNING：审批中  TERMINATED：被终止  COMPLETED：完成  CANCELED：取消
        @NameInMap("status")
        public String status;

        // 任务列表。
        @NameInMap("tasks")
        public java.util.List<GetProcessInstanceResponseBodyResultTasks> tasks;

        // 审批实例标题。
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
