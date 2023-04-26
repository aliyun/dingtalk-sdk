// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryPositionsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryPositionsResponseBody body;

    public static QueryPositionsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPositionsResponse self = new QueryPositionsResponse();
        return TeaModel.build(map, self);
    }

    public QueryPositionsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPositionsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPositionsResponse setBody(QueryPositionsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPositionsResponseBody getBody() {
        return this.body;
    }

}
