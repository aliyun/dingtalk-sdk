// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class DeleteTodoEETaskRequest extends TeaModel {
    @NameInMap("taskIds")
    public java.util.List<String> taskIds;

    public static DeleteTodoEETaskRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteTodoEETaskRequest self = new DeleteTodoEETaskRequest();
        return TeaModel.build(map, self);
    }

    public DeleteTodoEETaskRequest setTaskIds(java.util.List<String> taskIds) {
        this.taskIds = taskIds;
        return this;
    }
    public java.util.List<String> getTaskIds() {
        return this.taskIds;
    }

}
