// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpPointsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryCorpPointsResponse setBody(QueryCorpPointsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCorpPointsResponseBody getBody() {
        return this.body;
    }

}
