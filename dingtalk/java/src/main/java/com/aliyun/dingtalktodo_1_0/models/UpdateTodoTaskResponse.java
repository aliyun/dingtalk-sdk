// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateTodoTaskResponseBody body;

    public static UpdateTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTaskResponse self = new UpdateTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTodoTaskResponse setBody(UpdateTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTodoTaskResponseBody getBody() {
        return this.body;
    }

}
