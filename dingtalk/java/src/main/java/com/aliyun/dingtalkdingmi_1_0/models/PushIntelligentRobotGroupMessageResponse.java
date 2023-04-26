// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotGroupMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PushIntelligentRobotGroupMessageResponseBody body;

    public static PushIntelligentRobotGroupMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        PushIntelligentRobotGroupMessageResponse self = new PushIntelligentRobotGroupMessageResponse();
        return TeaModel.build(map, self);
    }

    public PushIntelligentRobotGroupMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushIntelligentRobotGroupMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PushIntelligentRobotGroupMessageResponse setBody(PushIntelligentRobotGroupMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public PushIntelligentRobotGroupMessageResponseBody getBody() {
        return this.body;
    }

}
