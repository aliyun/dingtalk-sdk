// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChatIdToOpenConversationIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatIdToOpenConversationIdResponseBody body;

    public static ChatIdToOpenConversationIdResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatIdToOpenConversationIdResponse self = new ChatIdToOpenConversationIdResponse();
        return TeaModel.build(map, self);
    }

    public ChatIdToOpenConversationIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatIdToOpenConversationIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatIdToOpenConversationIdResponse setBody(ChatIdToOpenConversationIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatIdToOpenConversationIdResponseBody getBody() {
        return this.body;
    }

}
