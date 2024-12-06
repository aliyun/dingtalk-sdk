// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class QueryAllTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static QueryAllTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllTaskRequest self = new QueryAllTaskRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllTaskRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
