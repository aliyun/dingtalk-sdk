// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ClearRobotPluginResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ClearRobotPluginResponse setBody(ClearRobotPluginResponseBody body) {
        this.body = body;
        return this;
    }
    public ClearRobotPluginResponseBody getBody() {
        return this.body;
    }

}
