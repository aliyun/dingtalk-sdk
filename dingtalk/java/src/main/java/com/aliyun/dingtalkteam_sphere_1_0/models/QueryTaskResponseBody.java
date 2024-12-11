// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class QueryTaskResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<QueryTaskResponseBodyResult> result;

    public static QueryTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTaskResponseBody self = new QueryTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTaskResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryTaskResponseBody setResult(java.util.List<QueryTaskResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryTaskResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryTaskResponseBodyResultCustomfieldsValue extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static QueryTaskResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            QueryTaskResponseBodyResultCustomfieldsValue self = new QueryTaskResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public QueryTaskResponseBodyResultCustomfieldsValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryTaskResponseBodyResultCustomfieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public QueryTaskResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryTaskResponseBodyResultCustomfields extends TeaModel {
        @NameInMap("cfId")
        public String cfId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<QueryTaskResponseBodyResultCustomfieldsValue> value;

        public static QueryTaskResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            QueryTaskResponseBodyResultCustomfields self = new QueryTaskResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public QueryTaskResponseBodyResultCustomfields setCfId(String cfId) {
            this.cfId = cfId;
            return this;
        }
        public String getCfId() {
            return this.cfId;
        }

        public QueryTaskResponseBodyResultCustomfields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryTaskResponseBodyResultCustomfields setValue(java.util.List<QueryTaskResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<QueryTaskResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class QueryTaskResponseBodyResultExecutorUserInfo extends TeaModel {
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("id")
        public String id;

        @NameInMap("memberId")
        public String memberId;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static QueryTaskResponseBodyResultExecutorUserInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryTaskResponseBodyResultExecutorUserInfo self = new QueryTaskResponseBodyResultExecutorUserInfo();
            return TeaModel.build(map, self);
        }

        public QueryTaskResponseBodyResultExecutorUserInfo setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public QueryTaskResponseBodyResultExecutorUserInfo setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryTaskResponseBodyResultExecutorUserInfo setMemberId(String memberId) {
            this.memberId = memberId;
            return this;
        }
        public String getMemberId() {
            return this.memberId;
        }

        public QueryTaskResponseBodyResultExecutorUserInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryTaskResponseBodyResultExecutorUserInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryTaskResponseBodyResultProjectInfo extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("logo")
        public String logo;

        @NameInMap("name")
        public String name;

        @NameInMap("organizationId")
        public String organizationId;

        public static QueryTaskResponseBodyResultProjectInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryTaskResponseBodyResultProjectInfo self = new QueryTaskResponseBodyResultProjectInfo();
            return TeaModel.build(map, self);
        }

        public QueryTaskResponseBodyResultProjectInfo setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryTaskResponseBodyResultProjectInfo setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public QueryTaskResponseBodyResultProjectInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryTaskResponseBodyResultProjectInfo setOrganizationId(String organizationId) {
            this.organizationId = organizationId;
            return this;
        }
        public String getOrganizationId() {
            return this.organizationId;
        }

    }

    public static class QueryTaskResponseBodyResult extends TeaModel {
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
        public java.util.List<QueryTaskResponseBodyResultCustomfields> customfields;

        @NameInMap("dueDate")
        public String dueDate;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("executorUserInfo")
        public QueryTaskResponseBodyResultExecutorUserInfo executorUserInfo;

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

        @NameInMap("projectInfo")
        public QueryTaskResponseBodyResultProjectInfo projectInfo;

        @NameInMap("taskId")
        @Deprecated
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static QueryTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryTaskResponseBodyResult self = new QueryTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryTaskResponseBodyResult setAccomplishTime(String accomplishTime) {
            this.accomplishTime = accomplishTime;
            return this;
        }
        public String getAccomplishTime() {
            return this.accomplishTime;
        }

        public QueryTaskResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QueryTaskResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public QueryTaskResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public QueryTaskResponseBodyResult setCustomfields(java.util.List<QueryTaskResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<QueryTaskResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
        }

        public QueryTaskResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public QueryTaskResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public QueryTaskResponseBodyResult setExecutorUserInfo(QueryTaskResponseBodyResultExecutorUserInfo executorUserInfo) {
            this.executorUserInfo = executorUserInfo;
            return this;
        }
        public QueryTaskResponseBodyResultExecutorUserInfo getExecutorUserInfo() {
            return this.executorUserInfo;
        }

        public QueryTaskResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryTaskResponseBodyResult setInvolveMembers(java.util.List<String> involveMembers) {
            this.involveMembers = involveMembers;
            return this;
        }
        public java.util.List<String> getInvolveMembers() {
            return this.involveMembers;
        }

        public QueryTaskResponseBodyResult setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public QueryTaskResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public QueryTaskResponseBodyResult setProjectId(String projectId) {
            this.projectId = projectId;
            return this;
        }
        public String getProjectId() {
            return this.projectId;
        }

        public QueryTaskResponseBodyResult setProjectInfo(QueryTaskResponseBodyResultProjectInfo projectInfo) {
            this.projectInfo = projectInfo;
            return this;
        }
        public QueryTaskResponseBodyResultProjectInfo getProjectInfo() {
            return this.projectInfo;
        }

        public QueryTaskResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public QueryTaskResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
