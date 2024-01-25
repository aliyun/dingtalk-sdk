// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotSendDingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RobotSendDingResponseBody body;

    public static RobotSendDingResponse build(java.util.Map<String, ?> map) throws Exception {
        RobotSendDingResponse self = new RobotSendDingResponse();
        return TeaModel.build(map, self);
    }

    public RobotSendDingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RobotSendDingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RobotSendDingResponse setBody(RobotSendDingResponseBody body) {
        this.body = body;
        return this;
    }
    public RobotSendDingResponseBody getBody() {
        return this.body;
    }

}
