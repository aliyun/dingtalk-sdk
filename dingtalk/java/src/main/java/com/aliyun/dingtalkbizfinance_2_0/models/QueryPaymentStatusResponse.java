// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPaymentStatusResponseBody body;

    public static QueryPaymentStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentStatusResponse self = new QueryPaymentStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryPaymentStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPaymentStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPaymentStatusResponse setBody(QueryPaymentStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPaymentStatusResponseBody getBody() {
        return this.body;
    }

}
