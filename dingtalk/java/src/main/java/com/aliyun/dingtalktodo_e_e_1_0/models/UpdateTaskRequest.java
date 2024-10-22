// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("done")
    public Boolean done;

    @NameInMap("dueTime")
    public Long dueTime;

    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("subject")
    public String subject;

    @NameInMap("taskId")
    public Long taskId;

    public static UpdateTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskRequest self = new UpdateTaskRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateTaskRequest setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public UpdateTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public UpdateTaskRequest setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public UpdateTaskRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public UpdateTaskRequest setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
