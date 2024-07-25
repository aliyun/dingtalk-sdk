// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBenefitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBenefitResponseBody body;

    public static QueryBenefitResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBenefitResponse self = new QueryBenefitResponse();
        return TeaModel.build(map, self);
    }

    public QueryBenefitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBenefitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBenefitResponse setBody(QueryBenefitResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBenefitResponseBody getBody() {
        return this.body;
    }

}
