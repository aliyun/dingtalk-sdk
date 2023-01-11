// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllProcessInstancesResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
    @NameInMap("result")
    public QueryAllProcessInstancesResponseBodyResult result;

    public static QueryAllProcessInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllProcessInstancesResponseBody self = new QueryAllProcessInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllProcessInstancesResponseBody setResult(QueryAllProcessInstancesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryAllProcessInstancesResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryAllProcessInstancesResponseBodyResultListFormComponentValues extends TeaModel {
        /**
         * <p>控件扩展数据</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <p>控件id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>控件名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>控件数据</p>
         */
        @NameInMap("value")
        public String value;

        public static QueryAllProcessInstancesResponseBodyResultListFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            QueryAllProcessInstancesResponseBodyResultListFormComponentValues self = new QueryAllProcessInstancesResponseBodyResultListFormComponentValues();
            return TeaModel.build(map, self);
        }

        public QueryAllProcessInstancesResponseBodyResultListFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public QueryAllProcessInstancesResponseBodyResultListFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryAllProcessInstancesResponseBodyResultListFormComponentValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryAllProcessInstancesResponseBodyResultListFormComponentValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments extends TeaModel {
        /**
         * <p>附件钉盘id</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <p>附件名称</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>文件大小</p>
         */
        @NameInMap("fileSize")
        public String fileSize;

        /**
         * <p>文件类型</p>
         */
        @NameInMap("fileType")
        public String fileType;

        public static QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments build(java.util.Map<String, ?> map) throws Exception {
            QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments self = new QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments();
            return TeaModel.build(map, self);
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments setFileSize(String fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public String getFileSize() {
            return this.fileSize;
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

    }

    public static class QueryAllProcessInstancesResponseBodyResultListOperationRecords extends TeaModel {
        /**
         * <p>评论附件</p>
         */
        @NameInMap("attachments")
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments> attachments;

        /**
         * <p>操作类型</p>
         */
        @NameInMap("operationType")
        public String operationType;

        /**
         * <p>评论</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>操作结果</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <p>操作时间戳</p>
         */
        @NameInMap("timestamp")
        public Long timestamp;

        /**
         * <p>操作人staffId</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryAllProcessInstancesResponseBodyResultListOperationRecords build(java.util.Map<String, ?> map) throws Exception {
            QueryAllProcessInstancesResponseBodyResultListOperationRecords self = new QueryAllProcessInstancesResponseBodyResultListOperationRecords();
            return TeaModel.build(map, self);
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecords setAttachments(java.util.List<QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments> getAttachments() {
            return this.attachments;
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecords setOperationType(String operationType) {
            this.operationType = operationType;
            return this;
        }
        public String getOperationType() {
            return this.operationType;
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecords setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecords setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecords setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public QueryAllProcessInstancesResponseBodyResultListOperationRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryAllProcessInstancesResponseBodyResultListTasks extends TeaModel {
        /**
         * <p>节点id</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <p>任务创建时间戳</p>
         */
        @NameInMap("createTimestamp")
        public Long createTimestamp;

        /**
         * <p>任务结束时间戳</p>
         */
        @NameInMap("finishTimestamp")
        public Long finishTimestamp;

        /**
         * <p>任务结果</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <p>任务状态</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>任务Id</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <p>任务处理人</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryAllProcessInstancesResponseBodyResultListTasks build(java.util.Map<String, ?> map) throws Exception {
            QueryAllProcessInstancesResponseBodyResultListTasks self = new QueryAllProcessInstancesResponseBodyResultListTasks();
            return TeaModel.build(map, self);
        }

        public QueryAllProcessInstancesResponseBodyResultListTasks setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public QueryAllProcessInstancesResponseBodyResultListTasks setCreateTimestamp(Long createTimestamp) {
            this.createTimestamp = createTimestamp;
            return this;
        }
        public Long getCreateTimestamp() {
            return this.createTimestamp;
        }

        public QueryAllProcessInstancesResponseBodyResultListTasks setFinishTimestamp(Long finishTimestamp) {
            this.finishTimestamp = finishTimestamp;
            return this;
        }
        public Long getFinishTimestamp() {
            return this.finishTimestamp;
        }

        public QueryAllProcessInstancesResponseBodyResultListTasks setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public QueryAllProcessInstancesResponseBodyResultListTasks setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryAllProcessInstancesResponseBodyResultListTasks setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public QueryAllProcessInstancesResponseBodyResultListTasks setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryAllProcessInstancesResponseBodyResultList extends TeaModel {
        /**
         * <p>附属单信息</p>
         */
        @NameInMap("attachedProcessInstanceIds")
        public String attachedProcessInstanceIds;

        /**
         * <p>审批单编号</p>
         */
        @NameInMap("businessId")
        public String businessId;

        /**
         * <p>审批单创建时间</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>审批结束时间</p>
         */
        @NameInMap("finishTime")
        public Long finishTime;

        @NameInMap("formComponentValues")
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> formComponentValues;

        /**
         * <p>主单实例Id</p>
         */
        @NameInMap("mainProcessInstanceId")
        public String mainProcessInstanceId;

        /**
         * <p>审批单操作记录</p>
         */
        @NameInMap("operationRecords")
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListOperationRecords> operationRecords;

        /**
         * <p>发起人部门id</p>
         */
        @NameInMap("originatorDeptId")
        public String originatorDeptId;

        /**
         * <p>发起者userId</p>
         */
        @NameInMap("originatorUserid")
        public String originatorUserid;

        /**
         * <p>流程实例ID</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <p>审批结果</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <p>审批单状态</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>任务列表</p>
         */
        @NameInMap("tasks")
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListTasks> tasks;

        /**
         * <p>审批单标题</p>
         */
        @NameInMap("title")
        public String title;

        public static QueryAllProcessInstancesResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            QueryAllProcessInstancesResponseBodyResultList self = new QueryAllProcessInstancesResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public QueryAllProcessInstancesResponseBodyResultList setAttachedProcessInstanceIds(String attachedProcessInstanceIds) {
            this.attachedProcessInstanceIds = attachedProcessInstanceIds;
            return this;
        }
        public String getAttachedProcessInstanceIds() {
            return this.attachedProcessInstanceIds;
        }

        public QueryAllProcessInstancesResponseBodyResultList setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public QueryAllProcessInstancesResponseBodyResultList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryAllProcessInstancesResponseBodyResultList setFinishTime(Long finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public Long getFinishTime() {
            return this.finishTime;
        }

        public QueryAllProcessInstancesResponseBodyResultList setFormComponentValues(java.util.List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> formComponentValues) {
            this.formComponentValues = formComponentValues;
            return this;
        }
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> getFormComponentValues() {
            return this.formComponentValues;
        }

        public QueryAllProcessInstancesResponseBodyResultList setMainProcessInstanceId(String mainProcessInstanceId) {
            this.mainProcessInstanceId = mainProcessInstanceId;
            return this;
        }
        public String getMainProcessInstanceId() {
            return this.mainProcessInstanceId;
        }

        public QueryAllProcessInstancesResponseBodyResultList setOperationRecords(java.util.List<QueryAllProcessInstancesResponseBodyResultListOperationRecords> operationRecords) {
            this.operationRecords = operationRecords;
            return this;
        }
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListOperationRecords> getOperationRecords() {
            return this.operationRecords;
        }

        public QueryAllProcessInstancesResponseBodyResultList setOriginatorDeptId(String originatorDeptId) {
            this.originatorDeptId = originatorDeptId;
            return this;
        }
        public String getOriginatorDeptId() {
            return this.originatorDeptId;
        }

        public QueryAllProcessInstancesResponseBodyResultList setOriginatorUserid(String originatorUserid) {
            this.originatorUserid = originatorUserid;
            return this;
        }
        public String getOriginatorUserid() {
            return this.originatorUserid;
        }

        public QueryAllProcessInstancesResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryAllProcessInstancesResponseBodyResultList setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public QueryAllProcessInstancesResponseBodyResultList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryAllProcessInstancesResponseBodyResultList setTasks(java.util.List<QueryAllProcessInstancesResponseBodyResultListTasks> tasks) {
            this.tasks = tasks;
            return this;
        }
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListTasks> getTasks() {
            return this.tasks;
        }

        public QueryAllProcessInstancesResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryAllProcessInstancesResponseBodyResult extends TeaModel {
        /**
         * <p>是否有更多数据</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<QueryAllProcessInstancesResponseBodyResultList> list;

        /**
         * <p>总数</p>
         */
        @NameInMap("maxResults")
        public Long maxResults;

        /**
         * <p>下次获取数据的游标</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        public static QueryAllProcessInstancesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAllProcessInstancesResponseBodyResult self = new QueryAllProcessInstancesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAllProcessInstancesResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public QueryAllProcessInstancesResponseBodyResult setList(java.util.List<QueryAllProcessInstancesResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<QueryAllProcessInstancesResponseBodyResultList> getList() {
            return this.list;
        }

        public QueryAllProcessInstancesResponseBodyResult setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public QueryAllProcessInstancesResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
