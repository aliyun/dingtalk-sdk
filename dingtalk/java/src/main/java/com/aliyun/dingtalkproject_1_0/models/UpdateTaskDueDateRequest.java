// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskDueDateRequest extends TeaModel {
    /**
     * <p>截止时间。</p>
     */
    @NameInMap("dueDate")
    public String dueDate;

    public static UpdateTaskDueDateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskDueDateRequest self = new UpdateTaskDueDateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskDueDateRequest setDueDate(String dueDate) {
        this.dueDate = dueDate;
        return this;
    }
    public String getDueDate() {
        return this.dueDate;
    }

}
