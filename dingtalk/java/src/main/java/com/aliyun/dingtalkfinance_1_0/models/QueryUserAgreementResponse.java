// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserAgreementResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserAgreementResponseBody body;

    public static QueryUserAgreementResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserAgreementResponse self = new QueryUserAgreementResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserAgreementResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserAgreementResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserAgreementResponse setBody(QueryUserAgreementResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserAgreementResponseBody getBody() {
        return this.body;
    }

}
