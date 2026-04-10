// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdatePersonalTodoTaskExecutorStatusRequest extends TeaModel {
    @NameInMap("done")
    public Boolean done;

    public static UpdatePersonalTodoTaskExecutorStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePersonalTodoTaskExecutorStatusRequest self = new UpdatePersonalTodoTaskExecutorStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePersonalTodoTaskExecutorStatusRequest setDone(Boolean done) {
        this.done = done;
        return this;
    }
    public Boolean getDone() {
        return this.done;
    }

}
