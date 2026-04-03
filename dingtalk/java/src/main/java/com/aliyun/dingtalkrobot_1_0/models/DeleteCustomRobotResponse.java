// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class DeleteCustomRobotResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteCustomRobotResponseBody body;

    public static DeleteCustomRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteCustomRobotResponse self = new DeleteCustomRobotResponse();
        return TeaModel.build(map, self);
    }

    public DeleteCustomRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteCustomRobotResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteCustomRobotResponse setBody(DeleteCustomRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteCustomRobotResponseBody getBody() {
        return this.body;
    }

}
