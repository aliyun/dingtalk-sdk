// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleTaskResultRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    @NameInMap("userId")
    public String userId;

    public static AISaleTaskResultRequest build(java.util.Map<String, ?> map) throws Exception {
        AISaleTaskResultRequest self = new AISaleTaskResultRequest();
        return TeaModel.build(map, self);
    }

    public AISaleTaskResultRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public AISaleTaskResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
