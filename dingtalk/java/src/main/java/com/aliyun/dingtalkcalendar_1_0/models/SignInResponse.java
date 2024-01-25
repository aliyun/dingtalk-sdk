// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class SignInResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SignInResponseBody body;

    public static SignInResponse build(java.util.Map<String, ?> map) throws Exception {
        SignInResponse self = new SignInResponse();
        return TeaModel.build(map, self);
    }

    public SignInResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SignInResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SignInResponse setBody(SignInResponseBody body) {
        this.body = body;
        return this;
    }
    public SignInResponseBody getBody() {
        return this.body;
    }

}
