// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppDeleteTodoEETaskResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AppDeleteTodoEETaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppDeleteTodoEETaskResponseBody self = new AppDeleteTodoEETaskResponseBody();
        return TeaModel.build(map, self);
    }

    public AppDeleteTodoEETaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
