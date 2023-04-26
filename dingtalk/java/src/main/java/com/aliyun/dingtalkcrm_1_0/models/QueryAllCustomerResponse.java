// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllCustomerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryAllCustomerResponseBody body;

    public static QueryAllCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllCustomerResponse self = new QueryAllCustomerResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllCustomerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllCustomerResponse setBody(QueryAllCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllCustomerResponseBody getBody() {
        return this.body;
    }

}
