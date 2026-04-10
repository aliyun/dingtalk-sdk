// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class DeletePersonalTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeletePersonalTodoTaskResponseBody body;

    public static DeletePersonalTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        DeletePersonalTodoTaskResponse self = new DeletePersonalTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public DeletePersonalTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeletePersonalTodoTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeletePersonalTodoTaskResponse setBody(DeletePersonalTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public DeletePersonalTodoTaskResponseBody getBody() {
        return this.body;
    }

}
