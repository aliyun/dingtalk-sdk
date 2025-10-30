// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryAsrTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskId")
    public String taskId;

    @NameInMap("unionId")
    public String unionId;

    public static QueryAsrTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAsrTaskRequest self = new QueryAsrTaskRequest();
        return TeaModel.build(map, self);
    }

    public QueryAsrTaskRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public QueryAsrTaskRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
