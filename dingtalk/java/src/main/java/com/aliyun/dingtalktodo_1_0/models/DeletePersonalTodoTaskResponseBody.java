// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class DeletePersonalTodoTaskResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static DeletePersonalTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeletePersonalTodoTaskResponseBody self = new DeletePersonalTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public DeletePersonalTodoTaskResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
