// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class SendRobotDingMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public SendRobotDingMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendRobotDingMessageResponse setBody(SendRobotDingMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendRobotDingMessageResponseBody getBody() {
        return this.body;
    }

}
