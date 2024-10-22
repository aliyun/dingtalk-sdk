// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserTaskStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateUserTaskStatusResponseBody body;

    public static UpdateUserTaskStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserTaskStatusResponse self = new UpdateUserTaskStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateUserTaskStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateUserTaskStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateUserTaskStatusResponse setBody(UpdateUserTaskStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateUserTaskStatusResponseBody getBody() {
        return this.body;
    }

}
