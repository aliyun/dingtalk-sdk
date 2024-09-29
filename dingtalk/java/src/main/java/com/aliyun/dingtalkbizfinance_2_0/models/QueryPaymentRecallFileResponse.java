// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentRecallFileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPaymentRecallFileResponseBody body;

    public static QueryPaymentRecallFileResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentRecallFileResponse self = new QueryPaymentRecallFileResponse();
        return TeaModel.build(map, self);
    }

    public QueryPaymentRecallFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPaymentRecallFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPaymentRecallFileResponse setBody(QueryPaymentRecallFileResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPaymentRecallFileResponseBody getBody() {
        return this.body;
    }

}
