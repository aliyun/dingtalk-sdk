// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIListDatasetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatAIListDatasetResponseBody body;

    public static ChatAIListDatasetResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatAIListDatasetResponse self = new ChatAIListDatasetResponse();
        return TeaModel.build(map, self);
    }

    public ChatAIListDatasetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatAIListDatasetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatAIListDatasetResponse setBody(ChatAIListDatasetResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatAIListDatasetResponseBody getBody() {
        return this.body;
    }

}
