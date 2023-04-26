// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryUserPointsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserPointsResponseBody body;

    public static QueryUserPointsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserPointsResponse self = new QueryUserPointsResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserPointsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserPointsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserPointsResponse setBody(QueryUserPointsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserPointsResponseBody getBody() {
        return this.body;
    }

}
