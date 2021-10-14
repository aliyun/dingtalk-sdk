// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBatchTradeDetailListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryBatchTradeDetailListResponse setBody(QueryBatchTradeDetailListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBatchTradeDetailListResponseBody getBody() {
        return this.body;
    }

}
