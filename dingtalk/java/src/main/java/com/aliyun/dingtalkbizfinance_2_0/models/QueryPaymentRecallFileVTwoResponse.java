// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentRecallFileVTwoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPaymentRecallFileVTwoResponseBody body;

    public static QueryPaymentRecallFileVTwoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentRecallFileVTwoResponse self = new QueryPaymentRecallFileVTwoResponse();
        return TeaModel.build(map, self);
    }

    public QueryPaymentRecallFileVTwoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPaymentRecallFileVTwoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPaymentRecallFileVTwoResponse setBody(QueryPaymentRecallFileVTwoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPaymentRecallFileVTwoResponseBody getBody() {
        return this.body;
    }

}
