// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskExecutorStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateTodoTaskExecutorStatusResponseBody body;

    public static UpdateTodoTaskExecutorStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTaskExecutorStatusResponse self = new UpdateTodoTaskExecutorStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTaskExecutorStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTodoTaskExecutorStatusResponse setBody(UpdateTodoTaskExecutorStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTodoTaskExecutorStatusResponseBody getBody() {
        return this.body;
    }

}
