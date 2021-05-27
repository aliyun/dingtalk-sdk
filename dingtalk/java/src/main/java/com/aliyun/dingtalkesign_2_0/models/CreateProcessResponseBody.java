// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CreateProcessResponseBody extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static CreateProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateProcessResponseBody self = new CreateProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateProcessResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
