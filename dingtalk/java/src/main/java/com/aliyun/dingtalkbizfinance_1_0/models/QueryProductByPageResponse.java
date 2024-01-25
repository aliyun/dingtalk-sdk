// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryProductByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryProductByPageResponseBody body;

    public static QueryProductByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryProductByPageResponse self = new QueryProductByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryProductByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryProductByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryProductByPageResponse setBody(QueryProductByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryProductByPageResponseBody getBody() {
        return this.body;
    }

}
