// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryRecentConversationsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRecentConversationsResponseBody body;

    public static QueryRecentConversationsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRecentConversationsResponse self = new QueryRecentConversationsResponse();
        return TeaModel.build(map, self);
    }

    public QueryRecentConversationsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRecentConversationsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRecentConversationsResponse setBody(QueryRecentConversationsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRecentConversationsResponseBody getBody() {
        return this.body;
    }

}
