// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryModelResultByTaskIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static QueryModelResultByTaskIdRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryModelResultByTaskIdRequest self = new QueryModelResultByTaskIdRequest();
        return TeaModel.build(map, self);
    }

    public QueryModelResultByTaskIdRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
