// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoUpdateKnowledgeGraphRelationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatMemoUpdateKnowledgeGraphRelationResponseBody body;

    public static ChatMemoUpdateKnowledgeGraphRelationResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoUpdateKnowledgeGraphRelationResponse self = new ChatMemoUpdateKnowledgeGraphRelationResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoUpdateKnowledgeGraphRelationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoUpdateKnowledgeGraphRelationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoUpdateKnowledgeGraphRelationResponse setBody(ChatMemoUpdateKnowledgeGraphRelationResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoUpdateKnowledgeGraphRelationResponseBody getBody() {
        return this.body;
    }

}
