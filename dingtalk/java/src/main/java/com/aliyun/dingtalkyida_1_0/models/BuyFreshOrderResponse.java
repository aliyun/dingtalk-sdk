// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BuyFreshOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BuyFreshOrderResponseBody body;

    public static BuyFreshOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        BuyFreshOrderResponse self = new BuyFreshOrderResponse();
        return TeaModel.build(map, self);
    }

    public BuyFreshOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BuyFreshOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BuyFreshOrderResponse setBody(BuyFreshOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public BuyFreshOrderResponseBody getBody() {
        return this.body;
    }

}
