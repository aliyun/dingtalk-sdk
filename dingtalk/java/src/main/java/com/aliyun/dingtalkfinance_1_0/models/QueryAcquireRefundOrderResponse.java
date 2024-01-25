// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryAcquireRefundOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public QueryAcquireRefundOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAcquireRefundOrderResponse setBody(QueryAcquireRefundOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAcquireRefundOrderResponseBody getBody() {
        return this.body;
    }

}
