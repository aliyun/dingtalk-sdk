// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetConversationSubtitleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetConversationSubtitleResponseBody body;

    public static SetConversationSubtitleResponse build(java.util.Map<String, ?> map) throws Exception {
        SetConversationSubtitleResponse self = new SetConversationSubtitleResponse();
        return TeaModel.build(map, self);
    }

    public SetConversationSubtitleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetConversationSubtitleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetConversationSubtitleResponse setBody(SetConversationSubtitleResponseBody body) {
        this.body = body;
        return this;
    }
    public SetConversationSubtitleResponseBody getBody() {
        return this.body;
    }

}
