// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreatePersonalTodoTaskResponseBody extends TeaModel {
    @NameInMap("createdTime")
    public Long createdTime;

    @NameInMap("taskId")
    public String taskId;

    public static CreatePersonalTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreatePersonalTodoTaskResponseBody self = new CreatePersonalTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreatePersonalTodoTaskResponseBody setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public CreatePersonalTodoTaskResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
