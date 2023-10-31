// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCustomerByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCustomerByPageResponseBody body;

    public static QueryCustomerByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerByPageResponse self = new QueryCustomerByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryCustomerByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCustomerByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCustomerByPageResponse setBody(QueryCustomerByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomerByPageResponseBody getBody() {
        return this.body;
    }

}
