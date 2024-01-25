// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendRobotMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public SendRobotMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendRobotMessageResponse setBody(SendRobotMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendRobotMessageResponseBody getBody() {
        return this.body;
    }

}
