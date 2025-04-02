// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryEnterpriseAccountSignUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryEnterpriseAccountSignUrlResponseBody body;

    public static QueryEnterpriseAccountSignUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEnterpriseAccountSignUrlResponse self = new QueryEnterpriseAccountSignUrlResponse();
        return TeaModel.build(map, self);
    }

    public QueryEnterpriseAccountSignUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEnterpriseAccountSignUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryEnterpriseAccountSignUrlResponse setBody(QueryEnterpriseAccountSignUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEnterpriseAccountSignUrlResponseBody getBody() {
        return this.body;
    }

}
