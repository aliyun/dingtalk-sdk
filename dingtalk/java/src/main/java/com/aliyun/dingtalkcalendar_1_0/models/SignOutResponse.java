// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class SignOutResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SignOutResponseBody body;

    public static SignOutResponse build(java.util.Map<String, ?> map) throws Exception {
        SignOutResponse self = new SignOutResponse();
        return TeaModel.build(map, self);
    }

    public SignOutResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SignOutResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SignOutResponse setBody(SignOutResponseBody body) {
        this.body = body;
        return this;
    }
    public SignOutResponseBody getBody() {
        return this.body;
    }

}
