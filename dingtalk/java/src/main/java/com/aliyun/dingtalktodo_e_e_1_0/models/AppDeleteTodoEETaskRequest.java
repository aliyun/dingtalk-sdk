// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppDeleteTodoEETaskRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("taskIds")
    public java.util.List<String> taskIds;

    public static AppDeleteTodoEETaskRequest build(java.util.Map<String, ?> map) throws Exception {
        AppDeleteTodoEETaskRequest self = new AppDeleteTodoEETaskRequest();
        return TeaModel.build(map, self);
    }

    public AppDeleteTodoEETaskRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public AppDeleteTodoEETaskRequest setTaskIds(java.util.List<String> taskIds) {
        this.taskIds = taskIds;
        return this;
    }
    public java.util.List<String> getTaskIds() {
        return this.taskIds;
    }

}
