// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

    public QueryCustomerByPageResponse setBody(QueryCustomerByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomerByPageResponseBody getBody() {
        return this.body;
    }

}
