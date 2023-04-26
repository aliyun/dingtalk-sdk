// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatSendResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PrivateChatSendResponseBody body;

    public static PrivateChatSendResponse build(java.util.Map<String, ?> map) throws Exception {
        PrivateChatSendResponse self = new PrivateChatSendResponse();
        return TeaModel.build(map, self);
    }

    public PrivateChatSendResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PrivateChatSendResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PrivateChatSendResponse setBody(PrivateChatSendResponseBody body) {
        this.body = body;
        return this;
    }
    public PrivateChatSendResponseBody getBody() {
        return this.body;
    }

}
