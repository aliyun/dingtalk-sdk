// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendRobotInteractiveCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendRobotInteractiveCardResponseBody body;

    public static SendRobotInteractiveCardResponse build(java.util.Map<String, ?> map) throws Exception {
        SendRobotInteractiveCardResponse self = new SendRobotInteractiveCardResponse();
        return TeaModel.build(map, self);
    }

    public SendRobotInteractiveCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendRobotInteractiveCardResponse setBody(SendRobotInteractiveCardResponseBody body) {
        this.body = body;
        return this;
    }
    public SendRobotInteractiveCardResponseBody getBody() {
        return this.body;
    }

}
