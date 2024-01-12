// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatFormGetDataForApiAccessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ChatFormGetDataForApiAccessResponseBody body;

    public static ChatFormGetDataForApiAccessResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatFormGetDataForApiAccessResponse self = new ChatFormGetDataForApiAccessResponse();
        return TeaModel.build(map, self);
    }

    public ChatFormGetDataForApiAccessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatFormGetDataForApiAccessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatFormGetDataForApiAccessResponse setBody(ChatFormGetDataForApiAccessResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatFormGetDataForApiAccessResponseBody getBody() {
        return this.body;
    }

}
