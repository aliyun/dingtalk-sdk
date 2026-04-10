// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdatePersonalTodoTaskRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("done")
    public Boolean done;

    @NameInMap("dueTime")
    public Long dueTime;

    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    @NameInMap("subject")
    public String subject;

    public static UpdatePersonalTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePersonalTodoTaskRequest self = new UpdatePersonalTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePersonalTodoTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdatePersonalTodoTaskRequest setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public UpdatePersonalTodoTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public UpdatePersonalTodoTaskRequest setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public UpdatePersonalTodoTaskRequest setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public UpdatePersonalTodoTaskRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

}
