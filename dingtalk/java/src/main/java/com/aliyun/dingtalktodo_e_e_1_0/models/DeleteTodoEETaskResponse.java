// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class DeleteTodoEETaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteTodoEETaskResponseBody body;

    public static DeleteTodoEETaskResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteTodoEETaskResponse self = new DeleteTodoEETaskResponse();
        return TeaModel.build(map, self);
    }

    public DeleteTodoEETaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteTodoEETaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteTodoEETaskResponse setBody(DeleteTodoEETaskResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteTodoEETaskResponseBody getBody() {
        return this.body;
    }

}
