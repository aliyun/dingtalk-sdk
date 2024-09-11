// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class OrderBillingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OrderBillingResponseBody body;

    public static OrderBillingResponse build(java.util.Map<String, ?> map) throws Exception {
        OrderBillingResponse self = new OrderBillingResponse();
        return TeaModel.build(map, self);
    }

    public OrderBillingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OrderBillingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OrderBillingResponse setBody(OrderBillingResponseBody body) {
        this.body = body;
        return this;
    }
    public OrderBillingResponseBody getBody() {
        return this.body;
    }

}
