// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskRequest extends TeaModel {
    // 待办描述备注
    @NameInMap("description")
    public String description;

    // 完成状态
    @NameInMap("done")
    public Boolean done;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 执行者列表，需传用户的unionId
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 参与者列表，需传用户的unionId
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 待办标题
    @NameInMap("subject")
    public String subject;

    // 当前操作者id，需传用户的unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTaskRequest self = new UpdateTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateTodoTaskRequest setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

    public UpdateTodoTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public UpdateTodoTaskRequest setExecutorIds(java.util.List<String> executorIds) {
        this.executorIds = executorIds;
        return this;
    }
    public java.util.List<String> getExecutorIds() {
        return this.executorIds;
    }

    public UpdateTodoTaskRequest setParticipantIds(java.util.List<String> participantIds) {
        this.participantIds = participantIds;
        return this;
    }
    public java.util.List<String> getParticipantIds() {
        return this.participantIds;
    }

    public UpdateTodoTaskRequest setSubject(String subject) {
        this.subject = subject;
        return this;
    }
    public String getSubject() {
        return this.subject;
    }

    public UpdateTodoTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
