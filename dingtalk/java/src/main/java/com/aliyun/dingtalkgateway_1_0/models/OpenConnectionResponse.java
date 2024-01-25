// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgateway_1_0.models;

import com.aliyun.tea.*;

public class OpenConnectionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenConnectionResponseBody body;

    public static OpenConnectionResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenConnectionResponse self = new OpenConnectionResponse();
        return TeaModel.build(map, self);
    }

    public OpenConnectionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenConnectionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenConnectionResponse setBody(OpenConnectionResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenConnectionResponseBody getBody() {
        return this.body;
    }

}
