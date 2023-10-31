// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcredit_1_0.models;

import com.aliyun.tea.*;

public class QueryScoreResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryScoreResponseBody body;

    public static QueryScoreResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryScoreResponse self = new QueryScoreResponse();
        return TeaModel.build(map, self);
    }

    public QueryScoreResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryScoreResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryScoreResponse setBody(QueryScoreResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryScoreResponseBody getBody() {
        return this.body;
    }

}
