// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoUpdateKnowledgeGraphNodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatMemoUpdateKnowledgeGraphNodeResponseBody body;

    public static ChatMemoUpdateKnowledgeGraphNodeResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoUpdateKnowledgeGraphNodeResponse self = new ChatMemoUpdateKnowledgeGraphNodeResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoUpdateKnowledgeGraphNodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoUpdateKnowledgeGraphNodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoUpdateKnowledgeGraphNodeResponse setBody(ChatMemoUpdateKnowledgeGraphNodeResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoUpdateKnowledgeGraphNodeResponseBody getBody() {
        return this.body;
    }

}
