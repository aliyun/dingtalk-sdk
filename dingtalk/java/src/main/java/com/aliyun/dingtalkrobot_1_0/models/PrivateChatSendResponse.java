// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatSendResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

    public PrivateChatSendResponse setBody(PrivateChatSendResponseBody body) {
        this.body = body;
        return this;
    }
    public PrivateChatSendResponseBody getBody() {
        return this.body;
    }

}
