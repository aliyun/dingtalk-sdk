// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ClearRobotPluginResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ClearRobotPluginResponseBody body;

    public static ClearRobotPluginResponse build(java.util.Map<String, ?> map) throws Exception {
        ClearRobotPluginResponse self = new ClearRobotPluginResponse();
        return TeaModel.build(map, self);
    }

    public ClearRobotPluginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ClearRobotPluginResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ClearRobotPluginResponse setBody(ClearRobotPluginResponseBody body) {
        this.body = body;
        return this;
    }
    public ClearRobotPluginResponseBody getBody() {
        return this.body;
    }

}
