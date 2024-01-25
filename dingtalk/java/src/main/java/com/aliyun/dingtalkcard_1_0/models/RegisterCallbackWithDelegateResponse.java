// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class RegisterCallbackWithDelegateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RegisterCallbackWithDelegateResponseBody body;

    public static RegisterCallbackWithDelegateResponse build(java.util.Map<String, ?> map) throws Exception {
        RegisterCallbackWithDelegateResponse self = new RegisterCallbackWithDelegateResponse();
        return TeaModel.build(map, self);
    }

    public RegisterCallbackWithDelegateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RegisterCallbackWithDelegateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RegisterCallbackWithDelegateResponse setBody(RegisterCallbackWithDelegateResponseBody body) {
        this.body = body;
        return this;
    }
    public RegisterCallbackWithDelegateResponseBody getBody() {
        return this.body;
    }

}
