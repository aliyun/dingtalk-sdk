// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class UpdateInstalledRobotResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateInstalledRobotResponseBody body;

    public static UpdateInstalledRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInstalledRobotResponse self = new UpdateInstalledRobotResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInstalledRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInstalledRobotResponse setBody(UpdateInstalledRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInstalledRobotResponseBody getBody() {
        return this.body;
    }

}
