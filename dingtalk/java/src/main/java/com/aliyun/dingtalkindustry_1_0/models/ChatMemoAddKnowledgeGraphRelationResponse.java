// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoAddKnowledgeGraphRelationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatMemoAddKnowledgeGraphRelationResponseBody body;

    public static ChatMemoAddKnowledgeGraphRelationResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoAddKnowledgeGraphRelationResponse self = new ChatMemoAddKnowledgeGraphRelationResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoAddKnowledgeGraphRelationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoAddKnowledgeGraphRelationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoAddKnowledgeGraphRelationResponse setBody(ChatMemoAddKnowledgeGraphRelationResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoAddKnowledgeGraphRelationResponseBody getBody() {
        return this.body;
    }

}
