// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class OrderInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OrderInfoResponseBody body;

    public static OrderInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        OrderInfoResponse self = new OrderInfoResponse();
        return TeaModel.build(map, self);
    }

    public OrderInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OrderInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OrderInfoResponse setBody(OrderInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public OrderInfoResponseBody getBody() {
        return this.body;
    }

}
