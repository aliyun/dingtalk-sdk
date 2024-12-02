// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoDeleteKnowledgeGraphRelationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatMemoDeleteKnowledgeGraphRelationResponseBody body;

    public static ChatMemoDeleteKnowledgeGraphRelationResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoDeleteKnowledgeGraphRelationResponse self = new ChatMemoDeleteKnowledgeGraphRelationResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoDeleteKnowledgeGraphRelationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoDeleteKnowledgeGraphRelationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoDeleteKnowledgeGraphRelationResponse setBody(ChatMemoDeleteKnowledgeGraphRelationResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoDeleteKnowledgeGraphRelationResponseBody getBody() {
        return this.body;
    }

}
