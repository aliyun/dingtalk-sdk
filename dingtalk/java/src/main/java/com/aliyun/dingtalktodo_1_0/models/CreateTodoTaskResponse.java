// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateTodoTaskResponseBody body;

    public static CreateTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTaskResponse self = new CreateTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTodoTaskResponse setBody(CreateTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTodoTaskResponseBody getBody() {
        return this.body;
    }

}
