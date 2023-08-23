// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class LogoutResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public LogoutResponseBody body;

    public static LogoutResponse build(java.util.Map<String, ?> map) throws Exception {
        LogoutResponse self = new LogoutResponse();
        return TeaModel.build(map, self);
    }

    public LogoutResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LogoutResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LogoutResponse setBody(LogoutResponseBody body) {
        this.body = body;
        return this;
    }
    public LogoutResponseBody getBody() {
        return this.body;
    }

}
