// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class ExecuteActivityResponseBody extends TeaModel {
    /**
     * <p>任务id</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static ExecuteActivityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExecuteActivityResponseBody self = new ExecuteActivityResponseBody();
        return TeaModel.build(map, self);
    }

    public ExecuteActivityResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
