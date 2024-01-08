// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoGetFileStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ChatMemoGetFileStatusResponseBody body;

    public static ChatMemoGetFileStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoGetFileStatusResponse self = new ChatMemoGetFileStatusResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoGetFileStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoGetFileStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoGetFileStatusResponse setBody(ChatMemoGetFileStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoGetFileStatusResponseBody getBody() {
        return this.body;
    }

}
