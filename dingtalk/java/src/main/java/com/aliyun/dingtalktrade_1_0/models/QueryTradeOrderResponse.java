// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class QueryTradeOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryTradeOrderResponseBody body;

    public static QueryTradeOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTradeOrderResponse self = new QueryTradeOrderResponse();
        return TeaModel.build(map, self);
    }

    public QueryTradeOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTradeOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTradeOrderResponse setBody(QueryTradeOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTradeOrderResponseBody getBody() {
        return this.body;
    }

}
