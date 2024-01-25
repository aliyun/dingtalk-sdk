// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryMultiCompanyInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMultiCompanyInfoResponseBody body;

    public static QueryMultiCompanyInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMultiCompanyInfoResponse self = new QueryMultiCompanyInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryMultiCompanyInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMultiCompanyInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMultiCompanyInfoResponse setBody(QueryMultiCompanyInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMultiCompanyInfoResponseBody getBody() {
        return this.body;
    }

}
