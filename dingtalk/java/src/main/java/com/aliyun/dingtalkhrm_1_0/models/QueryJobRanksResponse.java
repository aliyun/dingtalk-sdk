// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryJobRanksResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryJobRanksResponseBody body;

    public static QueryJobRanksResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryJobRanksResponse self = new QueryJobRanksResponse();
        return TeaModel.build(map, self);
    }

    public QueryJobRanksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryJobRanksResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryJobRanksResponse setBody(QueryJobRanksResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryJobRanksResponseBody getBody() {
        return this.body;
    }

}
