// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public QueryCustomerCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCustomerCardResponse setBody(QueryCustomerCardResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomerCardResponseBody getBody() {
        return this.body;
    }

}
