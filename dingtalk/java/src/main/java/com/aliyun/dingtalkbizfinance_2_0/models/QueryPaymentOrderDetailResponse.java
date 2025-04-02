// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentOrderDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPaymentOrderDetailResponseBody body;

    public static QueryPaymentOrderDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentOrderDetailResponse self = new QueryPaymentOrderDetailResponse();
        return TeaModel.build(map, self);
    }

    public QueryPaymentOrderDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPaymentOrderDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPaymentOrderDetailResponse setBody(QueryPaymentOrderDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPaymentOrderDetailResponseBody getBody() {
        return this.body;
    }

}
