// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskRequest extends TeaModel {
    /**
     * <p>待办描述备注</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>完成状态</p>
     */
    @NameInMap("done")
    public Boolean done;

    /**
     * <p>截止时间</p>
     */
    @NameInMap("dueTime")
    public Long dueTime;

    /**
     * <p>执行者列表，需传用户的unionId</p>
     */
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    /**
     * <p>参与者列表，需传用户的unionId</p>
     */
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    /**
     * <p>待办标题</p>
     */
    @NameInMap("subject")
    public String subject;

    /**
     * <p>当前操作者id，需传用户的unionId</p>
     */
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
