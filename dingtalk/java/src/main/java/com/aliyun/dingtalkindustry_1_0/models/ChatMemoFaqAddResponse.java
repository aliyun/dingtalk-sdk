// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqAddResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatMemoFaqAddResponseBody body;

    public static ChatMemoFaqAddResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoFaqAddResponse self = new ChatMemoFaqAddResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoFaqAddResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoFaqAddResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoFaqAddResponse setBody(ChatMemoFaqAddResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoFaqAddResponseBody getBody() {
        return this.body;
    }

}
