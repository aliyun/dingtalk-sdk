// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QuerySubjectPublicRiskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySubjectPublicRiskResponseBody body;

    public static QuerySubjectPublicRiskResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySubjectPublicRiskResponse self = new QuerySubjectPublicRiskResponse();
        return TeaModel.build(map, self);
    }

    public QuerySubjectPublicRiskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySubjectPublicRiskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySubjectPublicRiskResponse setBody(QuerySubjectPublicRiskResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySubjectPublicRiskResponseBody getBody() {
        return this.body;
    }

}
