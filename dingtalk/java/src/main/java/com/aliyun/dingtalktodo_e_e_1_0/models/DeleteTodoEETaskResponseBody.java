// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class DeleteTodoEETaskResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteTodoEETaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteTodoEETaskResponseBody self = new DeleteTodoEETaskResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteTodoEETaskResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
