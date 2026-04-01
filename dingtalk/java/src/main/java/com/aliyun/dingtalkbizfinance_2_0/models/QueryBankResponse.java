// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryBankResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBankResponseBody body;

    public static QueryBankResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBankResponse self = new QueryBankResponse();
        return TeaModel.build(map, self);
    }

    public QueryBankResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBankResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBankResponse setBody(QueryBankResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBankResponseBody getBody() {
        return this.body;
    }

}
