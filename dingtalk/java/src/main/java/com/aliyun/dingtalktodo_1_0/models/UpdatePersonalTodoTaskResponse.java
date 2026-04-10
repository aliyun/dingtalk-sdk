// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdatePersonalTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdatePersonalTodoTaskResponseBody body;

    public static UpdatePersonalTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdatePersonalTodoTaskResponse self = new UpdatePersonalTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public UpdatePersonalTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdatePersonalTodoTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdatePersonalTodoTaskResponse setBody(UpdatePersonalTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePersonalTodoTaskResponseBody getBody() {
        return this.body;
    }

}
