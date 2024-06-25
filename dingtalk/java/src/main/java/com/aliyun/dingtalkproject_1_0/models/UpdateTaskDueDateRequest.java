// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskDueDateRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2022-07-04T03:29:34.770Z</p>
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
