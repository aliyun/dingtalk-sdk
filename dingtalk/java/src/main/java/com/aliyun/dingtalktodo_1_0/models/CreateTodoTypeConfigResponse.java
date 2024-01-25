// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTypeConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateTodoTypeConfigResponseBody body;

    public static CreateTodoTypeConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTodoTypeConfigResponse self = new CreateTodoTypeConfigResponse();
        return TeaModel.build(map, self);
    }

    public CreateTodoTypeConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTodoTypeConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTodoTypeConfigResponse setBody(CreateTodoTypeConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTodoTypeConfigResponseBody getBody() {
        return this.body;
    }

}
