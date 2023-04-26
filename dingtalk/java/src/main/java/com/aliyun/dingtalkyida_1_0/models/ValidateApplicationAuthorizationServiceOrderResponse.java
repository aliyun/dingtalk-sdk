// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateApplicationAuthorizationServiceOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ValidateApplicationAuthorizationServiceOrderResponseBody body;

    public static ValidateApplicationAuthorizationServiceOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        ValidateApplicationAuthorizationServiceOrderResponse self = new ValidateApplicationAuthorizationServiceOrderResponse();
        return TeaModel.build(map, self);
    }

    public ValidateApplicationAuthorizationServiceOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ValidateApplicationAuthorizationServiceOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ValidateApplicationAuthorizationServiceOrderResponse setBody(ValidateApplicationAuthorizationServiceOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateApplicationAuthorizationServiceOrderResponseBody getBody() {
        return this.body;
    }

}
