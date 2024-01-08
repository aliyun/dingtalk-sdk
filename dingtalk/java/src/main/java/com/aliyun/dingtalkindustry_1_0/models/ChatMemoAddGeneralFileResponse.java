// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoAddGeneralFileResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ChatMemoAddGeneralFileResponseBody body;

    public static ChatMemoAddGeneralFileResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoAddGeneralFileResponse self = new ChatMemoAddGeneralFileResponse();
        return TeaModel.build(map, self);
    }

    public ChatMemoAddGeneralFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatMemoAddGeneralFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatMemoAddGeneralFileResponse setBody(ChatMemoAddGeneralFileResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatMemoAddGeneralFileResponseBody getBody() {
        return this.body;
    }

}
