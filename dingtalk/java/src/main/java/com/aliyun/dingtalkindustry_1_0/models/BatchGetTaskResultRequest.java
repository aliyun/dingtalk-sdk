// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class BatchGetTaskResultRequest extends TeaModel {
    @NameInMap("taskIds")
    public java.util.List<String> taskIds;

    public static BatchGetTaskResultRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetTaskResultRequest self = new BatchGetTaskResultRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetTaskResultRequest setTaskIds(java.util.List<String> taskIds) {
        this.taskIds = taskIds;
        return this;
    }
    public java.util.List<String> getTaskIds() {
        return this.taskIds;
    }

}
