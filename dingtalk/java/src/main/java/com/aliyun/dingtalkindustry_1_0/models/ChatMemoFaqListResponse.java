// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatMemoFaqListResponseBody body;

    public static ChatMemoFaqListResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoFaqListResponse self = new ChatMemoFaqListResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoFaqListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoFaqListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoFaqListResponse setBody(ChatMemoFaqListResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoFaqListResponseBody getBody() {
        return this.body;
    }

}
