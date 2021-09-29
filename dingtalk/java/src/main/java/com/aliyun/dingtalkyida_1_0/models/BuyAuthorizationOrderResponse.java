// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BuyAuthorizationOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BuyAuthorizationOrderResponse setBody(BuyAuthorizationOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public BuyAuthorizationOrderResponseBody getBody() {
        return this.body;
    }

}
