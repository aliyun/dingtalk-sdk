// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppUpdateTaskRequest extends TeaModel {
    @NameInMap("bizCreatedTime")
    public Long bizCreatedTime;

    @NameInMap("description")
    public String description;

    @NameInMap("done")
    public Boolean done;

    @NameInMap("dueTime")
    public Long dueTime;

    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("subject")
    public String subject;

    @NameInMap("taskId")
    public Long taskId;

    @NameInMap("toolbarTemplateKey")
    public String toolbarTemplateKey;

    public static AppUpdateTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        AppUpdateTaskRequest self = new AppUpdateTaskRequest();
        return TeaModel.build(map, self);
    }

    public AppUpdateTaskRequest setBizCreatedTime(Long bizCreatedTime) {
        this.bizCreatedTime = bizCreatedTime;
        return this;
    }
    public Long getBizCreatedTime() {
        return this.bizCreatedTime;
    }

    public AppUpdateTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public AppUpdateTaskRequest setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public AppUpdateTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public AppUpdateTaskRequest setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public AppUpdateTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public AppUpdateTaskRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public AppUpdateTaskRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

    public AppUpdateTaskRequest setToolbarTemplateKey(String toolbarTemplateKey) {
        this.toolbarTemplateKey = toolbarTemplateKey;
        return this;
    }
    public String getToolbarTemplateKey() {
        return this.toolbarTemplateKey;
    }

}
