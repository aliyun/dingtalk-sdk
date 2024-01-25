// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SetRobotConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetRobotConfigResponseBody body;

    public static SetRobotConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        SetRobotConfigResponse self = new SetRobotConfigResponse();
        return TeaModel.build(map, self);
    }

    public SetRobotConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetRobotConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetRobotConfigResponse setBody(SetRobotConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public SetRobotConfigResponseBody getBody() {
        return this.body;
    }

}
