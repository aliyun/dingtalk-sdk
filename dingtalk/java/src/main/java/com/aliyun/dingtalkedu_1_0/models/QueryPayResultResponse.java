// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPayResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPayResultResponseBody body;

    public static QueryPayResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPayResultResponse self = new QueryPayResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryPayResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPayResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPayResultResponse setBody(QueryPayResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPayResultResponseBody getBody() {
        return this.body;
    }

}
