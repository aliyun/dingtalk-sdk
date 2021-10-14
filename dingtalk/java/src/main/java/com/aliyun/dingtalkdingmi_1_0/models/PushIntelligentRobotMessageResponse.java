// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PushIntelligentRobotMessageResponseBody body;

    public static PushIntelligentRobotMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        PushIntelligentRobotMessageResponse self = new PushIntelligentRobotMessageResponse();
        return TeaModel.build(map, self);
    }

    public PushIntelligentRobotMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushIntelligentRobotMessageResponse setBody(PushIntelligentRobotMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public PushIntelligentRobotMessageResponseBody getBody() {
        return this.body;
    }

}
