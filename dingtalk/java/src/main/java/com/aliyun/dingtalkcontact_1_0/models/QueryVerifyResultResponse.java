// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryVerifyResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryVerifyResultResponseBody body;

    public static QueryVerifyResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryVerifyResultResponse self = new QueryVerifyResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryVerifyResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryVerifyResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryVerifyResultResponse setBody(QueryVerifyResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryVerifyResultResponseBody getBody() {
        return this.body;
    }

}
