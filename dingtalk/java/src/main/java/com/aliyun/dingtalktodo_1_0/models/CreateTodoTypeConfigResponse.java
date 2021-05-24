// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class CreateTodoTypeConfigResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateTodoTypeConfigResponse setBody(CreateTodoTypeConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTodoTypeConfigResponseBody getBody() {
        return this.body;
    }

}
