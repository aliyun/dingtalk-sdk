// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class OrderResaleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public OrderResaleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OrderResaleResponse setBody(OrderResaleResponseBody body) {
        this.body = body;
        return this;
    }
    public OrderResaleResponseBody getBody() {
        return this.body;
    }

}
