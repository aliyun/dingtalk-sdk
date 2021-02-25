// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendInteractiveCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendInteractiveCardResponseBody body;

    public static SendInteractiveCardResponse build(java.util.Map<String, ?> map) throws Exception {
        SendInteractiveCardResponse self = new SendInteractiveCardResponse();
        return TeaModel.build(map, self);
    }

    public SendInteractiveCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendInteractiveCardResponse setBody(SendInteractiveCardResponseBody body) {
        this.body = body;
        return this;
    }
    public SendInteractiveCardResponseBody getBody() {
        return this.body;
    }

}
