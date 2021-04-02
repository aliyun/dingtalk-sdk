// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class DeleteTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteTodoTaskResponseBody body;

    public static DeleteTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteTodoTaskResponse self = new DeleteTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public DeleteTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteTodoTaskResponse setBody(DeleteTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteTodoTaskResponseBody getBody() {
        return this.body;
    }

}
