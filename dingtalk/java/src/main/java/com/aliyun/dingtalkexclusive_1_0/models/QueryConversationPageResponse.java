// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryConversationPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryConversationPageResponseBody body;

    public static QueryConversationPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryConversationPageResponse self = new QueryConversationPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryConversationPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryConversationPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryConversationPageResponse setBody(QueryConversationPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryConversationPageResponseBody getBody() {
        return this.body;
    }

}
