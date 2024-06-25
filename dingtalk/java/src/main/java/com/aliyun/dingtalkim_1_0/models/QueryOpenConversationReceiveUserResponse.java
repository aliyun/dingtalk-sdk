// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryOpenConversationReceiveUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOpenConversationReceiveUserResponseBody body;

    public static QueryOpenConversationReceiveUserResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOpenConversationReceiveUserResponse self = new QueryOpenConversationReceiveUserResponse();
        return TeaModel.build(map, self);
    }

    public QueryOpenConversationReceiveUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOpenConversationReceiveUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOpenConversationReceiveUserResponse setBody(QueryOpenConversationReceiveUserResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOpenConversationReceiveUserResponseBody getBody() {
        return this.body;
    }

}
