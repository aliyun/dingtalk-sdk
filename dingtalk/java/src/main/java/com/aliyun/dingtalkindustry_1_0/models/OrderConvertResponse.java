// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class OrderConvertResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OrderConvertResponseBody body;

    public static OrderConvertResponse build(java.util.Map<String, ?> map) throws Exception {
        OrderConvertResponse self = new OrderConvertResponse();
        return TeaModel.build(map, self);
    }

    public OrderConvertResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OrderConvertResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OrderConvertResponse setBody(OrderConvertResponseBody body) {
        this.body = body;
        return this;
    }
    public OrderConvertResponseBody getBody() {
        return this.body;
    }

}
