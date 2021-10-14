// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryBatchTradeOrderResponseBody body;

    public static QueryBatchTradeOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchTradeOrderResponse self = new QueryBatchTradeOrderResponse();
        return TeaModel.build(map, self);
    }

    public QueryBatchTradeOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBatchTradeOrderResponse setBody(QueryBatchTradeOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBatchTradeOrderResponseBody getBody() {
        return this.body;
    }

}
