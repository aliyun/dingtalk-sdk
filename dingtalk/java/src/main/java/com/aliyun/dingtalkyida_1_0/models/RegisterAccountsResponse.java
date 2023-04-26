// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RegisterAccountsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RegisterAccountsResponseBody body;

    public static RegisterAccountsResponse build(java.util.Map<String, ?> map) throws Exception {
        RegisterAccountsResponse self = new RegisterAccountsResponse();
        return TeaModel.build(map, self);
    }

    public RegisterAccountsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RegisterAccountsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RegisterAccountsResponse setBody(RegisterAccountsResponseBody body) {
        this.body = body;
        return this;
    }
    public RegisterAccountsResponseBody getBody() {
        return this.body;
    }

}
