// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddRobotToConversationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddRobotToConversationResponseBody body;

    public static AddRobotToConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        AddRobotToConversationResponse self = new AddRobotToConversationResponse();
        return TeaModel.build(map, self);
    }

    public AddRobotToConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddRobotToConversationResponse setBody(AddRobotToConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public AddRobotToConversationResponseBody getBody() {
        return this.body;
    }

}
