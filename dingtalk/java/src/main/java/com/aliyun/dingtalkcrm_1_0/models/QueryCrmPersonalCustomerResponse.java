// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmPersonalCustomerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCrmPersonalCustomerResponseBody body;

    public static QueryCrmPersonalCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmPersonalCustomerResponse self = new QueryCrmPersonalCustomerResponse();
        return TeaModel.build(map, self);
    }

    public QueryCrmPersonalCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCrmPersonalCustomerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCrmPersonalCustomerResponse setBody(QueryCrmPersonalCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCrmPersonalCustomerResponseBody getBody() {
        return this.body;
    }

}
