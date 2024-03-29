// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CreateProcessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateProcessResponseBody body;

    public static CreateProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateProcessResponse self = new CreateProcessResponse();
        return TeaModel.build(map, self);
    }

    public CreateProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateProcessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateProcessResponse setBody(CreateProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateProcessResponseBody getBody() {
        return this.body;
    }

}
