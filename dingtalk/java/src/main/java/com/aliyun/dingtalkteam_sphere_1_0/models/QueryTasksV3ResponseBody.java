// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class QueryTasksV3ResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<QueryTasksV3ResponseBodyResult> result;

    public static QueryTasksV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTasksV3ResponseBody self = new QueryTasksV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTasksV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryTasksV3ResponseBody setResult(java.util.List<QueryTasksV3ResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryTasksV3ResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryTasksV3ResponseBodyResultCustomfieldsValue extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static QueryTasksV3ResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            QueryTasksV3ResponseBodyResultCustomfieldsValue self = new QueryTasksV3ResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public QueryTasksV3ResponseBodyResultCustomfieldsValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryTasksV3ResponseBodyResultCustomfieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public QueryTasksV3ResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryTasksV3ResponseBodyResultCustomfields extends TeaModel {
        @NameInMap("cfId")
        public String cfId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<QueryTasksV3ResponseBodyResultCustomfieldsValue> value;

        public static QueryTasksV3ResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            QueryTasksV3ResponseBodyResultCustomfields self = new QueryTasksV3ResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public QueryTasksV3ResponseBodyResultCustomfields setCfId(String cfId) {
            this.cfId = cfId;
            return this;
        }
        public String getCfId() {
            return this.cfId;
        }

        public QueryTasksV3ResponseBodyResultCustomfields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryTasksV3ResponseBodyResultCustomfields setValue(java.util.List<QueryTasksV3ResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<QueryTasksV3ResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class QueryTasksV3ResponseBodyResult extends TeaModel {
        @NameInMap("accomplishTime")
        public String accomplishTime;

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
        public java.util.List<QueryTasksV3ResponseBodyResultCustomfields> customfields;

        @NameInMap("dueDate")
        public String dueDate;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("id")
        public String id;

        @NameInMap("involveMembers")
        public java.util.List<String> involveMembers;

        @NameInMap("isDone")
        public Boolean isDone;

        @NameInMap("note")
        public String note;

        @NameInMap("projectId")
        public String projectId;

        @NameInMap("sourceId")
        public String sourceId;

        @NameInMap("taskId")
        @Deprecated
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static QueryTasksV3ResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryTasksV3ResponseBodyResult self = new QueryTasksV3ResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryTasksV3ResponseBodyResult setAccomplishTime(String accomplishTime) {
            this.accomplishTime = accomplishTime;
            return this;
        }
        public String getAccomplishTime() {
            return this.accomplishTime;
        }

        public QueryTasksV3ResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QueryTasksV3ResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public QueryTasksV3ResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryTasksV3ResponseBodyResult setCustomfields(java.util.List<QueryTasksV3ResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<QueryTasksV3ResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
        }

        public QueryTasksV3ResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public QueryTasksV3ResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public QueryTasksV3ResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryTasksV3ResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public QueryTasksV3ResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public QueryTasksV3ResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public QueryTasksV3ResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public QueryTasksV3ResponseBodyResult setSourceId(String sourceId) {
            this.sourceId = sourceId;
            return this;
        }
        public String getSourceId() {
            return this.sourceId;
        }

        @Deprecated
        public QueryTasksV3ResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public QueryTasksV3ResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
