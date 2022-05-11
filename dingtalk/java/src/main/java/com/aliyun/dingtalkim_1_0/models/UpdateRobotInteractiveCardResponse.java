// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotInteractiveCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateRobotInteractiveCardResponseBody body;

    public static UpdateRobotInteractiveCardResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRobotInteractiveCardResponse self = new UpdateRobotInteractiveCardResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRobotInteractiveCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRobotInteractiveCardResponse setBody(UpdateRobotInteractiveCardResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRobotInteractiveCardResponseBody getBody() {
        return this.body;
    }

}
