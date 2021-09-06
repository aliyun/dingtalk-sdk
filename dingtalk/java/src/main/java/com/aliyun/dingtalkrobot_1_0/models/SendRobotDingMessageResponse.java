// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class SendRobotDingMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendRobotDingMessageResponseBody body;

    public static SendRobotDingMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendRobotDingMessageResponse self = new SendRobotDingMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendRobotDingMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendRobotDingMessageResponse setBody(SendRobotDingMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendRobotDingMessageResponseBody getBody() {
        return this.body;
    }

}
