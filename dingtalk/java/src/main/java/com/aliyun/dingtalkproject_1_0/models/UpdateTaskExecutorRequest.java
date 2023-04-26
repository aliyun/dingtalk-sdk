// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskExecutorRequest extends TeaModel {
    @NameInMap("executorId")
    public String executorId;

    public static UpdateTaskExecutorRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskExecutorRequest self = new UpdateTaskExecutorRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskExecutorRequest setExecutorId(String executorId) {
        this.executorId = executorId;
        return this;
    }
    public String getExecutorId() {
        return this.executorId;
    }

}
