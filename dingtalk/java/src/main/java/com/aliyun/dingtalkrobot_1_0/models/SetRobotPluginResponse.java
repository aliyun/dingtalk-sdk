// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class SetRobotPluginResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetRobotPluginResponseBody body;

    public static SetRobotPluginResponse build(java.util.Map<String, ?> map) throws Exception {
        SetRobotPluginResponse self = new SetRobotPluginResponse();
        return TeaModel.build(map, self);
    }

    public SetRobotPluginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetRobotPluginResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetRobotPluginResponse setBody(SetRobotPluginResponseBody body) {
        this.body = body;
        return this;
    }
    public SetRobotPluginResponseBody getBody() {
        return this.body;
    }

}
