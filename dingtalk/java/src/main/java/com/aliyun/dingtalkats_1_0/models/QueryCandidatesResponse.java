// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryCandidatesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCandidatesResponseBody body;

    public static QueryCandidatesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCandidatesResponse self = new QueryCandidatesResponse();
        return TeaModel.build(map, self);
    }

    public QueryCandidatesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCandidatesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCandidatesResponse setBody(QueryCandidatesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCandidatesResponseBody getBody() {
        return this.body;
    }

}
