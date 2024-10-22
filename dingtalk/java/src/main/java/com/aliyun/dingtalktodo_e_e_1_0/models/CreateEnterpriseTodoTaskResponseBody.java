// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class CreateEnterpriseTodoTaskResponseBody extends TeaModel {
    @NameInMap("bizCategoryId")
    public String bizCategoryId;

    @NameInMap("createdTime")
    public Long createdTime;

    @NameInMap("creatorId")
    public String creatorId;

    @NameInMap("description")
    public String description;

    @NameInMap("detailUrl")
    public CreateEnterpriseTodoTaskResponseBodyDetailUrl detailUrl;

    @NameInMap("done")
    public Boolean done;

    @NameInMap("dueTime")
    public Long dueTime;

    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("modifiedTime")
    public Long modifiedTime;

    @NameInMap("sourceId")
    public String sourceId;

    @NameInMap("subject")
    public String subject;

    @NameInMap("taskId")
    public String taskId;

    public static CreateEnterpriseTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateEnterpriseTodoTaskResponseBody self = new CreateEnterpriseTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateEnterpriseTodoTaskResponseBody setBizCategoryId(String bizCategoryId) {
        this.bizCategoryId = bizCategoryId;
        return this;
    }
    public String getBizCategoryId() {
        return this.bizCategoryId;
    }

    public CreateEnterpriseTodoTaskResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public CreateEnterpriseTodoTaskResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public CreateEnterpriseTodoTaskResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateEnterpriseTodoTaskResponseBody setDetailUrl(CreateEnterpriseTodoTaskResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public CreateEnterpriseTodoTaskResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public CreateEnterpriseTodoTaskResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public CreateEnterpriseTodoTaskResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public CreateEnterpriseTodoTaskResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public CreateEnterpriseTodoTaskResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public CreateEnterpriseTodoTaskResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public CreateEnterpriseTodoTaskResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public CreateEnterpriseTodoTaskResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public static class CreateEnterpriseTodoTaskResponseBodyDetailUrl extends TeaModel {
        @NameInMap("appUrl")
        public String appUrl;

        @NameInMap("webUrl")
        public String webUrl;

        public static CreateEnterpriseTodoTaskResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            CreateEnterpriseTodoTaskResponseBodyDetailUrl self = new CreateEnterpriseTodoTaskResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public CreateEnterpriseTodoTaskResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public CreateEnterpriseTodoTaskResponseBodyDetailUrl setWebUrl(String webUrl) {
            this.webUrl = webUrl;
            return this;
        }
        public String getWebUrl() {
            return this.webUrl;
        }

    }

}
