// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdatePersonalTodoTaskResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdatePersonalTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdatePersonalTodoTaskResponseBody self = new UpdatePersonalTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdatePersonalTodoTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
