// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QuerySupplierByPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySupplierByPageResponseBody body;

    public static QuerySupplierByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySupplierByPageResponse self = new QuerySupplierByPageResponse();
        return TeaModel.build(map, self);
    }

    public QuerySupplierByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySupplierByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySupplierByPageResponse setBody(QuerySupplierByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySupplierByPageResponseBody getBody() {
        return this.body;
    }

}
