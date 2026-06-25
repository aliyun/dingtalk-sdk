// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateRobotResponseBody body;

    public static UpdateRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRobotResponse self = new UpdateRobotResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRobotResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateRobotResponse setBody(UpdateRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRobotResponseBody getBody() {
        return this.body;
    }

}
