// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class LoginCodeGenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public LoginCodeGenResponseBody body;

    public static LoginCodeGenResponse build(java.util.Map<String, ?> map) throws Exception {
        LoginCodeGenResponse self = new LoginCodeGenResponse();
        return TeaModel.build(map, self);
    }

    public LoginCodeGenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LoginCodeGenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LoginCodeGenResponse setBody(LoginCodeGenResponseBody body) {
        this.body = body;
        return this;
    }
    public LoginCodeGenResponseBody getBody() {
        return this.body;
    }

}
