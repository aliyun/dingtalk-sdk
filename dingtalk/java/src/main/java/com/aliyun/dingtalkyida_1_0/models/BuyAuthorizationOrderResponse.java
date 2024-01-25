// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BuyAuthorizationOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BuyAuthorizationOrderResponseBody body;

    public static BuyAuthorizationOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        BuyAuthorizationOrderResponse self = new BuyAuthorizationOrderResponse();
        return TeaModel.build(map, self);
    }

    public BuyAuthorizationOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BuyAuthorizationOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BuyAuthorizationOrderResponse setBody(BuyAuthorizationOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public BuyAuthorizationOrderResponseBody getBody() {
        return this.body;
    }

}
