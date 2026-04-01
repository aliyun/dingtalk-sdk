// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class HideUserTodoTaskResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static HideUserTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HideUserTodoTaskResponseBody self = new HideUserTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public HideUserTodoTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
