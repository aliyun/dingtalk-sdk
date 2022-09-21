// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendTopBoxInteractiveOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendTopBoxInteractiveOTOMessageResponseBody body;

    public static SendTopBoxInteractiveOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendTopBoxInteractiveOTOMessageResponse self = new SendTopBoxInteractiveOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendTopBoxInteractiveOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendTopBoxInteractiveOTOMessageResponse setBody(SendTopBoxInteractiveOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendTopBoxInteractiveOTOMessageResponseBody getBody() {
        return this.body;
    }

}
