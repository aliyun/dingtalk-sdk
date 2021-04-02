// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class DeleteTodoTaskResponseBody extends TeaModel {
    // 删除结果
    @NameInMap("result")
    public Boolean result;

    // requestId
    @NameInMap("requestId")
    public String requestId;

    public static DeleteTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteTodoTaskResponseBody self = new DeleteTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteTodoTaskResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public DeleteTodoTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
