// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendAgentOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendAgentOTOMessageResponseBody body;

    public static SendAgentOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendAgentOTOMessageResponse self = new SendAgentOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendAgentOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendAgentOTOMessageResponse setBody(SendAgentOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendAgentOTOMessageResponseBody getBody() {
        return this.body;
    }

}
