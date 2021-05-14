// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AskRobotResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AskRobotResponseBody body;

    public static AskRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        AskRobotResponse self = new AskRobotResponse();
        return TeaModel.build(map, self);
    }

    public AskRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AskRobotResponse setBody(AskRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public AskRobotResponseBody getBody() {
        return this.body;
    }

}
