// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChatIdToOpenConversationIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ChatIdToOpenConversationIdResponse setBody(ChatIdToOpenConversationIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatIdToOpenConversationIdResponseBody getBody() {
        return this.body;
    }

}
