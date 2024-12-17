// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppCreateEnterpriseTodoTaskResponseBody extends TeaModel {
    @NameInMap("bizCategoryId")
    public String bizCategoryId;

    @NameInMap("createdTime")
    public Long createdTime;

    @NameInMap("creatorId")
    public String creatorId;

    @NameInMap("description")
    public String description;

    @NameInMap("detailUrl")
    public AppCreateEnterpriseTodoTaskResponseBodyDetailUrl detailUrl;

    @NameInMap("done")
    public Boolean done;

    @NameInMap("dueTime")
    public Long dueTime;

    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("modifiedTime")
    public Long modifiedTime;

    @NameInMap("priority")
    public Integer priority;

    @NameInMap("sourceId")
    public String sourceId;

    @NameInMap("subject")
    public String subject;

    @NameInMap("taskId")
    public String taskId;

    public static AppCreateEnterpriseTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppCreateEnterpriseTodoTaskResponseBody self = new AppCreateEnterpriseTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public AppCreateEnterpriseTodoTaskResponseBody setBizCategoryId(String bizCategoryId) {
        this.bizCategoryId = bizCategoryId;
        return this;
    }
    public String getBizCategoryId() {
        return this.bizCategoryId;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setCreatorId(String creatorId) {
        this.creatorId = creatorId;
        return this;
    }
    public String getCreatorId() {
        return this.creatorId;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setDetailUrl(AppCreateEnterpriseTodoTaskResponseBodyDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public AppCreateEnterpriseTodoTaskResponseBodyDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setModifiedTime(Long modifiedTime) {
        this.modifiedTime = modifiedTime;
        return this;
    }
    public Long getModifiedTime() {
        return this.modifiedTime;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public AppCreateEnterpriseTodoTaskResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public static class AppCreateEnterpriseTodoTaskResponseBodyDetailUrl extends TeaModel {
        @NameInMap("appUrl")
        public String appUrl;

        @NameInMap("webUrl")
        public String webUrl;

        public static AppCreateEnterpriseTodoTaskResponseBodyDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            AppCreateEnterpriseTodoTaskResponseBodyDetailUrl self = new AppCreateEnterpriseTodoTaskResponseBodyDetailUrl();
            return TeaModel.build(map, self);
        }

        public AppCreateEnterpriseTodoTaskResponseBodyDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public AppCreateEnterpriseTodoTaskResponseBodyDetailUrl setWebUrl(String webUrl) {
            this.webUrl = webUrl;
            return this;
        }
        public String getWebUrl() {
            return this.webUrl;
        }

    }

}
