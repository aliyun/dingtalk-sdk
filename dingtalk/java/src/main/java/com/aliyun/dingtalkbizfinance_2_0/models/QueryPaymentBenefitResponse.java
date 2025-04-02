// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentBenefitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPaymentBenefitResponseBody body;

    public static QueryPaymentBenefitResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentBenefitResponse self = new QueryPaymentBenefitResponse();
        return TeaModel.build(map, self);
    }

    public QueryPaymentBenefitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPaymentBenefitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPaymentBenefitResponse setBody(QueryPaymentBenefitResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPaymentBenefitResponseBody getBody() {
        return this.body;
    }

}
