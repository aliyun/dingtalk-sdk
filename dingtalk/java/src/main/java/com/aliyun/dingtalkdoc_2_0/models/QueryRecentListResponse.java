// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryRecentListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRecentListResponseBody body;

    public static QueryRecentListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRecentListResponse self = new QueryRecentListResponse();
        return TeaModel.build(map, self);
    }

    public QueryRecentListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRecentListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRecentListResponse setBody(QueryRecentListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRecentListResponseBody getBody() {
        return this.body;
    }

}
