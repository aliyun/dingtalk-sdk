// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class RobotMessageRecallResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RobotMessageRecallResponseBody body;

    public static RobotMessageRecallResponse build(java.util.Map<String, ?> map) throws Exception {
        RobotMessageRecallResponse self = new RobotMessageRecallResponse();
        return TeaModel.build(map, self);
    }

    public RobotMessageRecallResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RobotMessageRecallResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RobotMessageRecallResponse setBody(RobotMessageRecallResponseBody body) {
        this.body = body;
        return this;
    }
    public RobotMessageRecallResponseBody getBody() {
        return this.body;
    }

}
