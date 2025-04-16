// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAiQueryLogsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatAiQueryLogsResponseBody body;

    public static ChatAiQueryLogsResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatAiQueryLogsResponse self = new ChatAiQueryLogsResponse();
        return TeaModel.build(map, self);
    }

    public ChatAiQueryLogsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatAiQueryLogsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatAiQueryLogsResponse setBody(ChatAiQueryLogsResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatAiQueryLogsResponseBody getBody() {
        return this.body;
    }

}
