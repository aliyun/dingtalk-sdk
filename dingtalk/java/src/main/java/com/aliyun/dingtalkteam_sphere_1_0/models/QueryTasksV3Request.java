// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class QueryTasksV3Request extends TeaModel {
    @NameInMap("parentTaskId")
    public String parentTaskId;

    @NameInMap("shortIds")
    public String shortIds;

    @NameInMap("taskId")
    public String taskId;

    public static QueryTasksV3Request build(java.util.Map<String, ?> map) throws Exception {
        QueryTasksV3Request self = new QueryTasksV3Request();
        return TeaModel.build(map, self);
    }

    public QueryTasksV3Request setParentTaskId(String parentTaskId) {
        this.parentTaskId = parentTaskId;
        return this;
    }
    public String getParentTaskId() {
        return this.parentTaskId;
    }

    public QueryTasksV3Request setShortIds(String shortIds) {
        this.shortIds = shortIds;
        return this;
    }
    public String getShortIds() {
        return this.shortIds;
    }

    public QueryTasksV3Request setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
