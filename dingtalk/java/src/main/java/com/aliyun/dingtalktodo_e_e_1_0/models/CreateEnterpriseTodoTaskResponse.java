// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class CreateEnterpriseTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateEnterpriseTodoTaskResponseBody body;

    public static CreateEnterpriseTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateEnterpriseTodoTaskResponse self = new CreateEnterpriseTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateEnterpriseTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateEnterpriseTodoTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateEnterpriseTodoTaskResponse setBody(CreateEnterpriseTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateEnterpriseTodoTaskResponseBody getBody() {
        return this.body;
    }

}
