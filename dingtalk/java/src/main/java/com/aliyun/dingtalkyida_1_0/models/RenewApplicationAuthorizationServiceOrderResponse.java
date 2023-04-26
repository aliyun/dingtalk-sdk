// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenewApplicationAuthorizationServiceOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RenewApplicationAuthorizationServiceOrderResponseBody body;

    public static RenewApplicationAuthorizationServiceOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        RenewApplicationAuthorizationServiceOrderResponse self = new RenewApplicationAuthorizationServiceOrderResponse();
        return TeaModel.build(map, self);
    }

    public RenewApplicationAuthorizationServiceOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RenewApplicationAuthorizationServiceOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RenewApplicationAuthorizationServiceOrderResponse setBody(RenewApplicationAuthorizationServiceOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public RenewApplicationAuthorizationServiceOrderResponseBody getBody() {
        return this.body;
    }

}
