// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryFinanceCompanyInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryFinanceCompanyInfoResponseBody body;

    public static QueryFinanceCompanyInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryFinanceCompanyInfoResponse self = new QueryFinanceCompanyInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryFinanceCompanyInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryFinanceCompanyInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryFinanceCompanyInfoResponse setBody(QueryFinanceCompanyInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryFinanceCompanyInfoResponseBody getBody() {
        return this.body;
    }

}
