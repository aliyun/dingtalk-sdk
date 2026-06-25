// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class EnableRobotResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EnableRobotResponseBody body;

    public static EnableRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        EnableRobotResponse self = new EnableRobotResponse();
        return TeaModel.build(map, self);
    }

    public EnableRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EnableRobotResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EnableRobotResponse setBody(EnableRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public EnableRobotResponseBody getBody() {
        return this.body;
    }

}
