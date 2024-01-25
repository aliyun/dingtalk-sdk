// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveRobotFromConversationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RemoveRobotFromConversationResponseBody body;

    public static RemoveRobotFromConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveRobotFromConversationResponse self = new RemoveRobotFromConversationResponse();
        return TeaModel.build(map, self);
    }

    public RemoveRobotFromConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveRobotFromConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveRobotFromConversationResponse setBody(RemoveRobotFromConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveRobotFromConversationResponseBody getBody() {
        return this.body;
    }

}
