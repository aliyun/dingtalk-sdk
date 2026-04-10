// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdatePersonalTodoTaskExecutorStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdatePersonalTodoTaskExecutorStatusResponseBody body;

    public static UpdatePersonalTodoTaskExecutorStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdatePersonalTodoTaskExecutorStatusResponse self = new UpdatePersonalTodoTaskExecutorStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdatePersonalTodoTaskExecutorStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdatePersonalTodoTaskExecutorStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdatePersonalTodoTaskExecutorStatusResponse setBody(UpdatePersonalTodoTaskExecutorStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePersonalTodoTaskExecutorStatusResponseBody getBody() {
        return this.body;
    }

}
