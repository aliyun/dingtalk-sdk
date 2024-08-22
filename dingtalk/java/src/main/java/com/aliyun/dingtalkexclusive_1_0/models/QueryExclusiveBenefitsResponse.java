// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryExclusiveBenefitsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryExclusiveBenefitsResponseBody body;

    public static QueryExclusiveBenefitsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryExclusiveBenefitsResponse self = new QueryExclusiveBenefitsResponse();
        return TeaModel.build(map, self);
    }

    public QueryExclusiveBenefitsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryExclusiveBenefitsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryExclusiveBenefitsResponse setBody(QueryExclusiveBenefitsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryExclusiveBenefitsResponseBody getBody() {
        return this.body;
    }

}
