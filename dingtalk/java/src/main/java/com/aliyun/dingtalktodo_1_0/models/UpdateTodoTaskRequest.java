// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskRequest extends TeaModel {
    // 待办标题
    @NameInMap("sucject")
    public String sucject;

    // 待办描述备注
    @NameInMap("description")
    public String description;

    // 截止时间
    @NameInMap("dueTime")
    public Long dueTime;

    // 完成状态
    @NameInMap("done")
    public Boolean done;

    // 执行者列表
    @NameInMap("executorIds")
    public java.util.List<String> executorIds;

    // 参与者列表
    @NameInMap("participantIds")
    public java.util.List<String> participantIds;

    // 当前操作者id
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTaskRequest self = new UpdateTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTaskRequest setSucject(String sucject) {
        this.sucject = sucject;
        return this;
    }
    public String getSucject() {
        return this.sucject;
    }

    public UpdateTodoTaskRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateTodoTaskRequest setDueTime(Long dueTime) {
        this.dueTime = dueTime;
        return this;
    }
    public Long getDueTime() {
        return this.dueTime;
    }

    public UpdateTodoTaskRequest setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
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

    public UpdateTodoTaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
