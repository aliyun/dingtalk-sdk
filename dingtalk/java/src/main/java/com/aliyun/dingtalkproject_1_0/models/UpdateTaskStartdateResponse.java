// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskStartdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateTaskStartdateResponseBody body;

    public static UpdateTaskStartdateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskStartdateResponse self = new UpdateTaskStartdateResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTaskStartdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTaskStartdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateTaskStartdateResponse setBody(UpdateTaskStartdateResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskStartdateResponseBody getBody() {
        return this.body;
    }

}
