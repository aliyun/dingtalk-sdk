// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryInstancePaymentOrderDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryInstancePaymentOrderDetailResponseBody body;

    public static QueryInstancePaymentOrderDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryInstancePaymentOrderDetailResponse self = new QueryInstancePaymentOrderDetailResponse();
        return TeaModel.build(map, self);
    }

    public QueryInstancePaymentOrderDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryInstancePaymentOrderDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryInstancePaymentOrderDetailResponse setBody(QueryInstancePaymentOrderDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInstancePaymentOrderDetailResponseBody getBody() {
        return this.body;
    }

}
