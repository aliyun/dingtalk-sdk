// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoGetFileListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ChatMemoGetFileListResponseBody body;

    public static ChatMemoGetFileListResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoGetFileListResponse self = new ChatMemoGetFileListResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoGetFileListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoGetFileListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoGetFileListResponse setBody(ChatMemoGetFileListResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoGetFileListResponseBody getBody() {
        return this.body;
    }

}
