// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryFeedWhiteListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryFeedWhiteListResponseBody body;

    public static QueryFeedWhiteListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryFeedWhiteListResponse self = new QueryFeedWhiteListResponse();
        return TeaModel.build(map, self);
    }

    public QueryFeedWhiteListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryFeedWhiteListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryFeedWhiteListResponse setBody(QueryFeedWhiteListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryFeedWhiteListResponseBody getBody() {
        return this.body;
    }

}
