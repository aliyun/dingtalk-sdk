// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public PushIntelligentRobotMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PushIntelligentRobotMessageResponse setBody(PushIntelligentRobotMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public PushIntelligentRobotMessageResponseBody getBody() {
        return this.body;
    }

}
