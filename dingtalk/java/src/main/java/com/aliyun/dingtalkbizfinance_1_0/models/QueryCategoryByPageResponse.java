// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCategoryByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCategoryByPageResponseBody body;

    public static QueryCategoryByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCategoryByPageResponse self = new QueryCategoryByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryCategoryByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCategoryByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCategoryByPageResponse setBody(QueryCategoryByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCategoryByPageResponseBody getBody() {
        return this.body;
    }

}
