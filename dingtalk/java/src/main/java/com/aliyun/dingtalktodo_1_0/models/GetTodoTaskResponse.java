// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetTodoTaskResponseBody body;

    public static GetTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTaskResponse self = new GetTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public GetTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTodoTaskResponse setBody(GetTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTodoTaskResponseBody getBody() {
        return this.body;
    }

}
