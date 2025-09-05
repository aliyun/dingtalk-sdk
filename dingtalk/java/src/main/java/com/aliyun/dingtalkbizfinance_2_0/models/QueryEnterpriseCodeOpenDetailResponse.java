// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseCodeOpenDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryEnterpriseCodeOpenDetailResponseBody body;

    public static QueryEnterpriseCodeOpenDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEnterpriseCodeOpenDetailResponse self = new QueryEnterpriseCodeOpenDetailResponse();
        return TeaModel.build(map, self);
    }

    public QueryEnterpriseCodeOpenDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEnterpriseCodeOpenDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryEnterpriseCodeOpenDetailResponse setBody(QueryEnterpriseCodeOpenDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEnterpriseCodeOpenDetailResponseBody getBody() {
        return this.body;
    }

}
