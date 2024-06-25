// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PagesExportInstancesResponseBody extends TeaModel {
    @NameInMap("result")
    public PagesExportInstancesResponseBodyResult result;

    public static PagesExportInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PagesExportInstancesResponseBody self = new PagesExportInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public PagesExportInstancesResponseBody setResult(PagesExportInstancesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PagesExportInstancesResponseBodyResult getResult() {
        return this.result;
    }

    public static class PagesExportInstancesResponseBodyResultListFormComponentValues extends TeaModel {
        @NameInMap("componentName")
        public String componentName;

        /**
         * <strong>example:</strong>
         * <p>{&quot;staffId&quot;:&quot;abcd&quot;}</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>TextField-a32bcdef</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("value")
        public String value;

        public static PagesExportInstancesResponseBodyResultListFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            PagesExportInstancesResponseBodyResultListFormComponentValues self = new PagesExportInstancesResponseBodyResultListFormComponentValues();
            return TeaModel.build(map, self);
        }

        public PagesExportInstancesResponseBodyResultListFormComponentValues setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public PagesExportInstancesResponseBodyResultListFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public PagesExportInstancesResponseBodyResultListFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PagesExportInstancesResponseBodyResultListFormComponentValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PagesExportInstancesResponseBodyResultListFormComponentValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PagesExportInstancesResponseBodyResultListOperationRecordsAttachments extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1234567</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <strong>example:</strong>
         * <p>附件</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("fileSize")
        public String fileSize;

        /**
         * <strong>example:</strong>
         * <p>pdf</p>
         */
        @NameInMap("fileType")
        public String fileType;

        public static PagesExportInstancesResponseBodyResultListOperationRecordsAttachments build(java.util.Map<String, ?> map) throws Exception {
            PagesExportInstancesResponseBodyResultListOperationRecordsAttachments self = new PagesExportInstancesResponseBodyResultListOperationRecordsAttachments();
            return TeaModel.build(map, self);
        }

        public PagesExportInstancesResponseBodyResultListOperationRecordsAttachments setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecordsAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecordsAttachments setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecordsAttachments setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

    }

    public static class PagesExportInstancesResponseBodyResultListOperationRecords extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1234_abcd</p>
         */
        @NameInMap("activityId")
        public String activityId;

        @NameInMap("attachments")
        public java.util.List<PagesExportInstancesResponseBodyResultListOperationRecordsAttachments> attachments;

        /**
         * <strong>example:</strong>
         * <p>[]</p>
         */
        @NameInMap("images")
        public java.util.List<String> images;

        /**
         * <strong>example:</strong>
         * <p>EXECUTE_TASK_NORMAL（正常执行任务），EXECUTE_TASK_AGENT（代理人执行任务），APPEND_TASK_BEFORE（前加签任务），APPEND_TASK_AFTER（后加签任务），REDIRECT_TASK（转交任务），START_PROCESS_INSTANCE（发起流程实例），TERMINATE_PROCESS_INSTANCE（终止(撤销)流程实例），FINISH_PROCESS_INSTANCE（结束流程实例），ADD_REMARK（添加评论）</p>
         */
        @NameInMap("operationType")
        public String operationType;

        /**
         * <strong>example:</strong>
         * <p>同意</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <strong>example:</strong>
         * <p>AGREE（同意），REFUSE（拒绝），NONE（未知）</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>1657522271000</p>
         */
        @NameInMap("timestamp")
        public Long timestamp;

        /**
         * <strong>example:</strong>
         * <p>manager1</p>
         */
        @NameInMap("userId")
        public String userId;

        public static PagesExportInstancesResponseBodyResultListOperationRecords build(java.util.Map<String, ?> map) throws Exception {
            PagesExportInstancesResponseBodyResultListOperationRecords self = new PagesExportInstancesResponseBodyResultListOperationRecords();
            return TeaModel.build(map, self);
        }

        public PagesExportInstancesResponseBodyResultListOperationRecords setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecords setAttachments(java.util.List<PagesExportInstancesResponseBodyResultListOperationRecordsAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<PagesExportInstancesResponseBodyResultListOperationRecordsAttachments> getAttachments() {
            return this.attachments;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecords setImages(java.util.List<String> images) {
            this.images = images;
            return this;
        }
        public java.util.List<String> getImages() {
            return this.images;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecords setOperationType(String operationType) {
            this.operationType = operationType;
            return this;
        }
        public String getOperationType() {
            return this.operationType;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecords setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecords setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecords setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecords setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public PagesExportInstancesResponseBodyResultListOperationRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class PagesExportInstancesResponseBodyResultListTasks extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1234_abcd</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <strong>example:</strong>
         * <p>1657522271000</p>
         */
        @NameInMap("createTimestamp")
        public Long createTimestamp;

        /**
         * <strong>example:</strong>
         * <p>1657522271000</p>
         */
        @NameInMap("finishTimestamp")
        public Long finishTimestamp;

        /**
         * <strong>example:</strong>
         * <p>分为AGREE（同意），REFUSE（拒绝），REDIRECTED（转交）</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>NEW（未启动），RUNNING（处理中），PAUSED（暂停），CANCELED（取消），COMPLETED（完成），TERMINATED（终止）</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>123456</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>staff1234</p>
         */
        @NameInMap("userId")
        public String userId;

        public static PagesExportInstancesResponseBodyResultListTasks build(java.util.Map<String, ?> map) throws Exception {
            PagesExportInstancesResponseBodyResultListTasks self = new PagesExportInstancesResponseBodyResultListTasks();
            return TeaModel.build(map, self);
        }

        public PagesExportInstancesResponseBodyResultListTasks setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public PagesExportInstancesResponseBodyResultListTasks setCreateTimestamp(Long createTimestamp) {
            this.createTimestamp = createTimestamp;
            return this;
        }
        public Long getCreateTimestamp() {
            return this.createTimestamp;
        }

        public PagesExportInstancesResponseBodyResultListTasks setFinishTimestamp(Long finishTimestamp) {
            this.finishTimestamp = finishTimestamp;
            return this;
        }
        public Long getFinishTimestamp() {
            return this.finishTimestamp;
        }

        public PagesExportInstancesResponseBodyResultListTasks setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public PagesExportInstancesResponseBodyResultListTasks setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public PagesExportInstancesResponseBodyResultListTasks setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public PagesExportInstancesResponseBodyResultListTasks setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class PagesExportInstancesResponseBodyResultList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>cdef-dae2fd2-example</p>
         */
        @NameInMap("attachedProcessInstanceIds")
        public String attachedProcessInstanceIds;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>202110111558000355024</p>
         */
        @NameInMap("businessId")
        public String businessId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1635165470201</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1633795200000</p>
         */
        @NameInMap("finishTime")
        public Long finishTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formComponentValues")
        public java.util.List<PagesExportInstancesResponseBodyResultListFormComponentValues> formComponentValues;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dcdse-dae2fd2-example</p>
         */
        @NameInMap("mainProcessInstanceId")
        public String mainProcessInstanceId;

        @NameInMap("operationRecords")
        public java.util.List<PagesExportInstancesResponseBodyResultListOperationRecords> operationRecords;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>默认-1，企业根部门</p>
         */
        @NameInMap("originatorDeptId")
        public String originatorDeptId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>staff1234</p>
         */
        @NameInMap("originatorUserid")
        public String originatorUserid;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abcdse-dse-example</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>AGREE同意，REFUSE拒绝</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>RUNNING审批中、TERMINATED撤销、COMPLETED审批完成、CANCELED取消</p>
         */
        @NameInMap("status")
        public String status;

        @NameInMap("tasks")
        public java.util.List<PagesExportInstancesResponseBodyResultListTasks> tasks;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>员工A提交的小肖审批单</p>
         */
        @NameInMap("title")
        public String title;

        public static PagesExportInstancesResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            PagesExportInstancesResponseBodyResultList self = new PagesExportInstancesResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public PagesExportInstancesResponseBodyResultList setAttachedProcessInstanceIds(String attachedProcessInstanceIds) {
            this.attachedProcessInstanceIds = attachedProcessInstanceIds;
            return this;
        }
        public String getAttachedProcessInstanceIds() {
            return this.attachedProcessInstanceIds;
        }

        public PagesExportInstancesResponseBodyResultList setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public PagesExportInstancesResponseBodyResultList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public PagesExportInstancesResponseBodyResultList setFinishTime(Long finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public Long getFinishTime() {
            return this.finishTime;
        }

        public PagesExportInstancesResponseBodyResultList setFormComponentValues(java.util.List<PagesExportInstancesResponseBodyResultListFormComponentValues> formComponentValues) {
            this.formComponentValues = formComponentValues;
            return this;
        }
        public java.util.List<PagesExportInstancesResponseBodyResultListFormComponentValues> getFormComponentValues() {
            return this.formComponentValues;
        }

        public PagesExportInstancesResponseBodyResultList setMainProcessInstanceId(String mainProcessInstanceId) {
            this.mainProcessInstanceId = mainProcessInstanceId;
            return this;
        }
        public String getMainProcessInstanceId() {
            return this.mainProcessInstanceId;
        }

        public PagesExportInstancesResponseBodyResultList setOperationRecords(java.util.List<PagesExportInstancesResponseBodyResultListOperationRecords> operationRecords) {
            this.operationRecords = operationRecords;
            return this;
        }
        public java.util.List<PagesExportInstancesResponseBodyResultListOperationRecords> getOperationRecords() {
            return this.operationRecords;
        }

        public PagesExportInstancesResponseBodyResultList setOriginatorDeptId(String originatorDeptId) {
            this.originatorDeptId = originatorDeptId;
            return this;
        }
        public String getOriginatorDeptId() {
            return this.originatorDeptId;
        }

        public PagesExportInstancesResponseBodyResultList setOriginatorUserid(String originatorUserid) {
            this.originatorUserid = originatorUserid;
            return this;
        }
        public String getOriginatorUserid() {
            return this.originatorUserid;
        }

        public PagesExportInstancesResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public PagesExportInstancesResponseBodyResultList setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public PagesExportInstancesResponseBodyResultList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public PagesExportInstancesResponseBodyResultList setTasks(java.util.List<PagesExportInstancesResponseBodyResultListTasks> tasks) {
            this.tasks = tasks;
            return this;
        }
        public java.util.List<PagesExportInstancesResponseBodyResultListTasks> getTasks() {
            return this.tasks;
        }

        public PagesExportInstancesResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class PagesExportInstancesResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<PagesExportInstancesResponseBodyResultList> list;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        public static PagesExportInstancesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PagesExportInstancesResponseBodyResult self = new PagesExportInstancesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PagesExportInstancesResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public PagesExportInstancesResponseBodyResult setList(java.util.List<PagesExportInstancesResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<PagesExportInstancesResponseBodyResultList> getList() {
            return this.list;
        }

        public PagesExportInstancesResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
