// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class EnableCustomRobotResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EnableCustomRobotResponseBody body;

    public static EnableCustomRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        EnableCustomRobotResponse self = new EnableCustomRobotResponse();
        return TeaModel.build(map, self);
    }

    public EnableCustomRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EnableCustomRobotResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EnableCustomRobotResponse setBody(EnableCustomRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public EnableCustomRobotResponseBody getBody() {
        return this.body;
    }

}
