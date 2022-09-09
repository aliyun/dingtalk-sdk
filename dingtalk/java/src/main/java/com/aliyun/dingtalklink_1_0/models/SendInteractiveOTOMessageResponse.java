// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendInteractiveOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendInteractiveOTOMessageResponseBody body;

    public static SendInteractiveOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendInteractiveOTOMessageResponse self = new SendInteractiveOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendInteractiveOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendInteractiveOTOMessageResponse setBody(SendInteractiveOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendInteractiveOTOMessageResponseBody getBody() {
        return this.body;
    }

}