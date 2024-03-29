// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeDetailListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBatchTradeDetailListResponseBody body;

    public static QueryBatchTradeDetailListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBatchTradeDetailListResponse self = new QueryBatchTradeDetailListResponse();
        return TeaModel.build(map, self);
    }

    public QueryBatchTradeDetailListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBatchTradeDetailListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBatchTradeDetailListResponse setBody(QueryBatchTradeDetailListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBatchTradeDetailListResponseBody getBody() {
        return this.body;
    }

}
