// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class GetTodoTypeConfigResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetTodoTypeConfigResponseBody body;

    public static GetTodoTypeConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTodoTypeConfigResponse self = new GetTodoTypeConfigResponse();
        return TeaModel.build(map, self);
    }

    public GetTodoTypeConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTodoTypeConfigResponse setBody(GetTodoTypeConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTodoTypeConfigResponseBody getBody() {
        return this.body;
    }

}
