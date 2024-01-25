// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryReceiptsByPageResponseBody body;

    public static QueryReceiptsByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptsByPageResponse self = new QueryReceiptsByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryReceiptsByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryReceiptsByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryReceiptsByPageResponse setBody(QueryReceiptsByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryReceiptsByPageResponseBody getBody() {
        return this.body;
    }

}
