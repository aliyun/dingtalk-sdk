// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseAccountByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryEnterpriseAccountByPageResponseBody body;

    public static QueryEnterpriseAccountByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEnterpriseAccountByPageResponse self = new QueryEnterpriseAccountByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryEnterpriseAccountByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEnterpriseAccountByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryEnterpriseAccountByPageResponse setBody(QueryEnterpriseAccountByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEnterpriseAccountByPageResponseBody getBody() {
        return this.body;
    }

}
