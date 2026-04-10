// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdatePersonalTodoTaskExecutorStatusResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdatePersonalTodoTaskExecutorStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdatePersonalTodoTaskExecutorStatusResponseBody self = new UpdatePersonalTodoTaskExecutorStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdatePersonalTodoTaskExecutorStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
