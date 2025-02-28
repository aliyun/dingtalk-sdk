// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCollectionOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCollectionOrderResponseBody body;

    public static QueryCollectionOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectionOrderResponse self = new QueryCollectionOrderResponse();
        return TeaModel.build(map, self);
    }

    public QueryCollectionOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCollectionOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCollectionOrderResponse setBody(QueryCollectionOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCollectionOrderResponseBody getBody() {
        return this.body;
    }

}
