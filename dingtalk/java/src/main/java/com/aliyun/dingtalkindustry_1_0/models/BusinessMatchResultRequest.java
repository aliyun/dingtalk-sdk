// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class BusinessMatchResultRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    @NameInMap("userId")
    public String userId;

    public static BusinessMatchResultRequest build(java.util.Map<String, ?> map) throws Exception {
        BusinessMatchResultRequest self = new BusinessMatchResultRequest();
        return TeaModel.build(map, self);
    }

    public BusinessMatchResultRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public BusinessMatchResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
