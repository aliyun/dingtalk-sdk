// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class BusinessMatchResponseBody extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static BusinessMatchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BusinessMatchResponseBody self = new BusinessMatchResponseBody();
        return TeaModel.build(map, self);
    }

    public BusinessMatchResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
