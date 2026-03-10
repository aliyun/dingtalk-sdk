// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotReplyEmotionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RobotReplyEmotionResponseBody body;

    public static RobotReplyEmotionResponse build(java.util.Map<String, ?> map) throws Exception {
        RobotReplyEmotionResponse self = new RobotReplyEmotionResponse();
        return TeaModel.build(map, self);
    }

    public RobotReplyEmotionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RobotReplyEmotionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RobotReplyEmotionResponse setBody(RobotReplyEmotionResponseBody body) {
        this.body = body;
        return this;
    }
    public RobotReplyEmotionResponseBody getBody() {
        return this.body;
    }

}
