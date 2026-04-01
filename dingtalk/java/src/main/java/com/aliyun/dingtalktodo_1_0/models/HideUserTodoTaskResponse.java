// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class HideUserTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HideUserTodoTaskResponseBody body;

    public static HideUserTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        HideUserTodoTaskResponse self = new HideUserTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public HideUserTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HideUserTodoTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HideUserTodoTaskResponse setBody(HideUserTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public HideUserTodoTaskResponseBody getBody() {
        return this.body;
    }

}
