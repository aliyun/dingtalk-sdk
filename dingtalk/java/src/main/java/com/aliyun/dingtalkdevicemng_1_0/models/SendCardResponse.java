// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class SendCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendCardResponseBody body;

    public static SendCardResponse build(java.util.Map<String, ?> map) throws Exception {
        SendCardResponse self = new SendCardResponse();
        return TeaModel.build(map, self);
    }

    public SendCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendCardResponse setBody(SendCardResponseBody body) {
        this.body = body;
        return this;
    }
    public SendCardResponseBody getBody() {
        return this.body;
    }

}
