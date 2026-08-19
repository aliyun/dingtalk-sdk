// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryFileProcessResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryFileProcessResultResponseBody body;

    public static QueryFileProcessResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryFileProcessResultResponse self = new QueryFileProcessResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryFileProcessResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryFileProcessResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryFileProcessResultResponse setBody(QueryFileProcessResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryFileProcessResultResponseBody getBody() {
        return this.body;
    }

}
