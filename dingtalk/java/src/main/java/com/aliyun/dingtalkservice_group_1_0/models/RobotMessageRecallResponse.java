// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class RobotMessageRecallResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public RobotMessageRecallResponse setBody(RobotMessageRecallResponseBody body) {
        this.body = body;
        return this;
    }
    public RobotMessageRecallResponseBody getBody() {
        return this.body;
    }

}
