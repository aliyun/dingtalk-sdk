// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateVirusScanTaskResponseBody extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static CreateVirusScanTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateVirusScanTaskResponseBody self = new CreateVirusScanTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateVirusScanTaskResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
