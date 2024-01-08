// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqDeleteResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ChatMemoFaqDeleteResponseBody body;

    public static ChatMemoFaqDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoFaqDeleteResponse self = new ChatMemoFaqDeleteResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoFaqDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoFaqDeleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoFaqDeleteResponse setBody(ChatMemoFaqDeleteResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoFaqDeleteResponseBody getBody() {
        return this.body;
    }

}
