// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class PushHistoricalReceiptsResponseBody extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static PushHistoricalReceiptsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushHistoricalReceiptsResponseBody self = new PushHistoricalReceiptsResponseBody();
        return TeaModel.build(map, self);
    }

    public PushHistoricalReceiptsResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
