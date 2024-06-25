// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentryResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("async")
    public Boolean async;

    /**
     * <strong>example:</strong>
     * <p>task_id</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static DeleteDentryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentryResponseBody self = new DeleteDentryResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteDentryResponseBody setAsync(Boolean async) {
        this.async = async;
        return this;
    }
    public Boolean getAsync() {
        return this.async;
    }

    public DeleteDentryResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
