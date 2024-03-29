// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class QueryMarketOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMarketOrderResponseBody body;

    public static QueryMarketOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMarketOrderResponse self = new QueryMarketOrderResponse();
        return TeaModel.build(map, self);
    }

    public QueryMarketOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMarketOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMarketOrderResponse setBody(QueryMarketOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMarketOrderResponseBody getBody() {
        return this.body;
    }

}
