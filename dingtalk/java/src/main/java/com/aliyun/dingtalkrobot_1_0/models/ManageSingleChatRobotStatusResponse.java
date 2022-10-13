// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class ManageSingleChatRobotStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ManageSingleChatRobotStatusResponseBody body;

    public static ManageSingleChatRobotStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        ManageSingleChatRobotStatusResponse self = new ManageSingleChatRobotStatusResponse();
        return TeaModel.build(map, self);
    }

    public ManageSingleChatRobotStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ManageSingleChatRobotStatusResponse setBody(ManageSingleChatRobotStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public ManageSingleChatRobotStatusResponseBody getBody() {
        return this.body;
    }

}
