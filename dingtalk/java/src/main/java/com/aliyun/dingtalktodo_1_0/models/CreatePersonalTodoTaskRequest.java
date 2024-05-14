// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreatePersonalTodoTaskRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("dueTime")
    public Long dueTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    @NameInMap("notifyConfigs")
    public CreatePersonalTodoTaskRequestNotifyConfigs notifyConfigs;

    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subject")
    public String subject;

    public static CreatePersonalTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreatePersonalTodoTaskRequest self = new CreatePersonalTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreatePersonalTodoTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreatePersonalTodoTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public CreatePersonalTodoTaskRequest setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public CreatePersonalTodoTaskRequest setNotifyConfigs(CreatePersonalTodoTaskRequestNotifyConfigs notifyConfigs) {
        this.notifyConfigs = notifyConfigs;
        return this;
    }
    public CreatePersonalTodoTaskRequestNotifyConfigs getNotifyConfigs() {
        return this.notifyConfigs;
    }

    public CreatePersonalTodoTaskRequest setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public CreatePersonalTodoTaskRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public static class CreatePersonalTodoTaskRequestNotifyConfigs extends TeaModel {
        @NameInMap("dingNotify")
        public String dingNotify;

        public static CreatePersonalTodoTaskRequestNotifyConfigs build(java.util.Map<String, ?> map) throws Exception {
            CreatePersonalTodoTaskRequestNotifyConfigs self = new CreatePersonalTodoTaskRequestNotifyConfigs();
            return TeaModel.build(map, self);
        }

        public CreatePersonalTodoTaskRequestNotifyConfigs setDingNotify(String dingNotify) {
            this.dingNotify = dingNotify;
            return this;
        }
        public String getDingNotify() {
            return this.dingNotify;
        }

    }

}
