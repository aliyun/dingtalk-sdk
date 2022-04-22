// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCustomerCardResponseBody body;

    public static QueryCustomerCardResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerCardResponse self = new QueryCustomerCardResponse();
        return TeaModel.build(map, self);
    }

    public QueryCustomerCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCustomerCardResponse setBody(QueryCustomerCardResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomerCardResponseBody getBody() {
        return this.body;
    }

}
