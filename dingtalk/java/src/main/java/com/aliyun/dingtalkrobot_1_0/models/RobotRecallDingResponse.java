// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotRecallDingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RobotRecallDingResponseBody body;

    public static RobotRecallDingResponse build(java.util.Map<String, ?> map) throws Exception {
        RobotRecallDingResponse self = new RobotRecallDingResponse();
        return TeaModel.build(map, self);
    }

    public RobotRecallDingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RobotRecallDingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RobotRecallDingResponse setBody(RobotRecallDingResponseBody body) {
        this.body = body;
        return this;
    }
    public RobotRecallDingResponseBody getBody() {
        return this.body;
    }

}
