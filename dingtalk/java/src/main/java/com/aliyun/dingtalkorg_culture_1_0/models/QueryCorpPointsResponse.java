// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpPointsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCorpPointsResponseBody body;

    public static QueryCorpPointsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpPointsResponse self = new QueryCorpPointsResponse();
        return TeaModel.build(map, self);
    }

    public QueryCorpPointsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCorpPointsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCorpPointsResponse setBody(QueryCorpPointsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCorpPointsResponseBody getBody() {
        return this.body;
    }

}
