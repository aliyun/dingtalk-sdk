// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoDeleteKnowledgeGraphNodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatMemoDeleteKnowledgeGraphNodeResponseBody body;

    public static ChatMemoDeleteKnowledgeGraphNodeResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoDeleteKnowledgeGraphNodeResponse self = new ChatMemoDeleteKnowledgeGraphNodeResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoDeleteKnowledgeGraphNodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoDeleteKnowledgeGraphNodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoDeleteKnowledgeGraphNodeResponse setBody(ChatMemoDeleteKnowledgeGraphNodeResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoDeleteKnowledgeGraphNodeResponseBody getBody() {
        return this.body;
    }

}
