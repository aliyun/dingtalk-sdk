// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTypeConfigResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateTodoTypeConfigResponseBody body;

    public static UpdateTodoTypeConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTodoTypeConfigResponse self = new UpdateTodoTypeConfigResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTodoTypeConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTodoTypeConfigResponse setBody(UpdateTodoTypeConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTodoTypeConfigResponseBody getBody() {
        return this.body;
    }

}
