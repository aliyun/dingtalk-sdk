// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class LoginForVisitorResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public LoginForVisitorResponseBody body;

    public static LoginForVisitorResponse build(java.util.Map<String, ?> map) throws Exception {
        LoginForVisitorResponse self = new LoginForVisitorResponse();
        return TeaModel.build(map, self);
    }

    public LoginForVisitorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LoginForVisitorResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LoginForVisitorResponse setBody(LoginForVisitorResponseBody body) {
        this.body = body;
        return this;
    }
    public LoginForVisitorResponseBody getBody() {
        return this.body;
    }

}
