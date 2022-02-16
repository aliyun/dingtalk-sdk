// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryAcquireRefundOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryAcquireRefundOrderResponseBody body;

    public static QueryAcquireRefundOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAcquireRefundOrderResponse self = new QueryAcquireRefundOrderResponse();
        return TeaModel.build(map, self);
    }

    public QueryAcquireRefundOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAcquireRefundOrderResponse setBody(QueryAcquireRefundOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAcquireRefundOrderResponseBody getBody() {
        return this.body;
    }

}
