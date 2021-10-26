// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QuerySupplierByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QuerySupplierByPageResponse setBody(QuerySupplierByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySupplierByPageResponseBody getBody() {
        return this.body;
    }

}
