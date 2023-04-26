// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskPriorityRequest extends TeaModel {
    @NameInMap("priority")
    public Integer priority;

    public static UpdateTaskPriorityRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskPriorityRequest self = new UpdateTaskPriorityRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskPriorityRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

}
