// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoQueryKnowledgeGraphNodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatMemoQueryKnowledgeGraphNodeResponseBody body;

    public static ChatMemoQueryKnowledgeGraphNodeResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoQueryKnowledgeGraphNodeResponse self = new ChatMemoQueryKnowledgeGraphNodeResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoQueryKnowledgeGraphNodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoQueryKnowledgeGraphNodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoQueryKnowledgeGraphNodeResponse setBody(ChatMemoQueryKnowledgeGraphNodeResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoQueryKnowledgeGraphNodeResponseBody getBody() {
        return this.body;
    }

}
