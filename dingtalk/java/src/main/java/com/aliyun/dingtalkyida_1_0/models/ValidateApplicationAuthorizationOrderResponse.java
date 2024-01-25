// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateApplicationAuthorizationOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ValidateApplicationAuthorizationOrderResponseBody body;

    public static ValidateApplicationAuthorizationOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        ValidateApplicationAuthorizationOrderResponse self = new ValidateApplicationAuthorizationOrderResponse();
        return TeaModel.build(map, self);
    }

    public ValidateApplicationAuthorizationOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ValidateApplicationAuthorizationOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ValidateApplicationAuthorizationOrderResponse setBody(ValidateApplicationAuthorizationOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateApplicationAuthorizationOrderResponseBody getBody() {
        return this.body;
    }

}
