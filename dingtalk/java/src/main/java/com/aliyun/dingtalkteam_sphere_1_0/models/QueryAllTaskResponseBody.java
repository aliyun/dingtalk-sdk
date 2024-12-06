// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class QueryAllTaskResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<QueryAllTaskResponseBodyResult> result;

    public static QueryAllTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllTaskResponseBody self = new QueryAllTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryAllTaskResponseBody setResult(java.util.List<QueryAllTaskResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryAllTaskResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryAllTaskResponseBodyResultCustomfieldsValue extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static QueryAllTaskResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            QueryAllTaskResponseBodyResultCustomfieldsValue self = new QueryAllTaskResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public QueryAllTaskResponseBodyResultCustomfieldsValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryAllTaskResponseBodyResultCustomfieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public QueryAllTaskResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryAllTaskResponseBodyResultCustomfields extends TeaModel {
        @NameInMap("cfId")
        public String cfId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<QueryAllTaskResponseBodyResultCustomfieldsValue> value;

        public static QueryAllTaskResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            QueryAllTaskResponseBodyResultCustomfields self = new QueryAllTaskResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public QueryAllTaskResponseBodyResultCustomfields setCfId(String cfId) {
            this.cfId = cfId;
            return this;
        }
        public String getCfId() {
            return this.cfId;
        }

        public QueryAllTaskResponseBodyResultCustomfields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryAllTaskResponseBodyResultCustomfields setValue(java.util.List<QueryAllTaskResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<QueryAllTaskResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class QueryAllTaskResponseBodyResult extends TeaModel {
        @NameInMap("accomplishTime")
        public String accomplishTime;

        @NameInMap("ancestorIds")
        public java.util.List<String> ancestorIds;

        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customfields")
        public java.util.List<QueryAllTaskResponseBodyResultCustomfields> customfields;

        @NameInMap("dueDate")
        public String dueDate;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("id")
        public String id;

        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        @NameInMap("isArchived")
        public Boolean isArchived;

        @NameInMap("isDone")
        public Boolean isDone;

        @NameInMap("note")
        public String note;

        @NameInMap("parentTaskId")
        public String parentTaskId;

        @NameInMap("priority")
        public Integer priority;

        @NameInMap("projectId")
        public String projectId;

        @NameInMap("sfcId")
        public String sfcId;

        @NameInMap("stageId")
        public String stageId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("startDate")
        public String startDate;

        @NameInMap("tagIds")
        public java.util.List<String> tagIds;

        @NameInMap("taskId")
        @Deprecated
        public String taskId;

        @NameInMap("tasklistId")
        public String tasklistId;

        @NameInMap("tfsId")
        public String tfsId;

        @NameInMap("uniqueId")
        public String uniqueId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        @NameInMap("visible")
        public String visible;

        public static QueryAllTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAllTaskResponseBodyResult self = new QueryAllTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAllTaskResponseBodyResult setAccomplishTime(String accomplishTime) {
            this.accomplishTime = accomplishTime;
            return this;
        }
        public String getAccomplishTime() {
            return this.accomplishTime;
        }

        public QueryAllTaskResponseBodyResult setAncestorIds(java.util.List<String> ancestorIds) {
            this.ancestorIds = ancestorIds;
            return this;
        }
        public java.util.List<String> getAncestorIds() {
            return this.ancestorIds;
        }

        public QueryAllTaskResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QueryAllTaskResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public QueryAllTaskResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryAllTaskResponseBodyResult setCustomfields(java.util.List<QueryAllTaskResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<QueryAllTaskResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
        }

        public QueryAllTaskResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public QueryAllTaskResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public QueryAllTaskResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryAllTaskResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public QueryAllTaskResponseBodyResult setIsArchived(Boolean isArchived) {
            this.isArchived = isArchived;
            return this;
        }
        public Boolean getIsArchived() {
            return this.isArchived;
        }

        public QueryAllTaskResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public QueryAllTaskResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public QueryAllTaskResponseBodyResult setParentTaskId(String parentTaskId) {
            this.parentTaskId = parentTaskId;
            return this;
        }
        public String getParentTaskId() {
            return this.parentTaskId;
        }

        public QueryAllTaskResponseBodyResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public QueryAllTaskResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public QueryAllTaskResponseBodyResult setSfcId(String sfcId) {
            this.sfcId = sfcId;
            return this;
        }
        public String getSfcId() {
            return this.sfcId;
        }

        public QueryAllTaskResponseBodyResult setStageId(String stageId) {
            this.stageId = stageId;
            return this;
        }
        public String getStageId() {
            return this.stageId;
        }

        public QueryAllTaskResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public QueryAllTaskResponseBodyResult setTagIds(java.util.List<String> tagIds) {
            this.tagIds = tagIds;
            return this;
        }
        public java.util.List<String> getTagIds() {
            return this.tagIds;
        }

        public QueryAllTaskResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public QueryAllTaskResponseBodyResult setTasklistId(String tasklistId) {
            this.tasklistId = tasklistId;
            return this;
        }
        public String getTasklistId() {
            return this.tasklistId;
        }

        public QueryAllTaskResponseBodyResult setTfsId(String tfsId) {
            this.tfsId = tfsId;
            return this;
        }
        public String getTfsId() {
            return this.tfsId;
        }

        public QueryAllTaskResponseBodyResult setUniqueId(String uniqueId) {
            this.uniqueId = uniqueId;
            return this;
        }
        public String getUniqueId() {
            return this.uniqueId;
        }

        public QueryAllTaskResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public QueryAllTaskResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
