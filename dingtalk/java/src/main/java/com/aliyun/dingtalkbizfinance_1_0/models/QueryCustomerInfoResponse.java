// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCustomerInfoResponseBody body;

    public static QueryCustomerInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerInfoResponse self = new QueryCustomerInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryCustomerInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCustomerInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCustomerInfoResponse setBody(QueryCustomerInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomerInfoResponseBody getBody() {
        return this.body;
    }

}
