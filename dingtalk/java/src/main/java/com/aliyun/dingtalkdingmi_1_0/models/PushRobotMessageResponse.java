// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushRobotMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PushRobotMessageResponseBody body;

    public static PushRobotMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        PushRobotMessageResponse self = new PushRobotMessageResponse();
        return TeaModel.build(map, self);
    }

    public PushRobotMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushRobotMessageResponse setBody(PushRobotMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public PushRobotMessageResponseBody getBody() {
        return this.body;
    }

}
