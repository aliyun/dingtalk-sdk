// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class SendRobotMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendRobotMessageResponseBody body;

    public static SendRobotMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendRobotMessageResponse self = new SendRobotMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendRobotMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendRobotMessageResponse setBody(SendRobotMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendRobotMessageResponseBody getBody() {
        return this.body;
    }

}
