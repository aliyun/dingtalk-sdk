// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class UpdateTodoTypeConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public UpdateTodoTypeConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateTodoTypeConfigResponse setBody(UpdateTodoTypeConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTodoTypeConfigResponseBody getBody() {
        return this.body;
    }

}
