// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class OrderResaleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OrderResaleResponseBody body;

    public static OrderResaleResponse build(java.util.Map<String, ?> map) throws Exception {
        OrderResaleResponse self = new OrderResaleResponse();
        return TeaModel.build(map, self);
    }

    public OrderResaleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OrderResaleResponse setBody(OrderResaleResponseBody body) {
        this.body = body;
        return this;
    }
    public OrderResaleResponseBody getBody() {
        return this.body;
    }

}
