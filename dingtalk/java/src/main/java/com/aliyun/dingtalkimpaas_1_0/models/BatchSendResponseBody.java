// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class BatchSendResponseBody extends TeaModel {
    // 任务Id
    @NameInMap("taskId")
    public String taskId;

    public static BatchSendResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchSendResponseBody self = new BatchSendResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchSendResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
