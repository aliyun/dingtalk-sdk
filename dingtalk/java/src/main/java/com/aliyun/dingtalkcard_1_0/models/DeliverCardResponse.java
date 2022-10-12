// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class DeliverCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeliverCardResponseBody body;

    public static DeliverCardResponse build(java.util.Map<String, ?> map) throws Exception {
        DeliverCardResponse self = new DeliverCardResponse();
        return TeaModel.build(map, self);
    }

    public DeliverCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeliverCardResponse setBody(DeliverCardResponseBody body) {
        this.body = body;
        return this;
    }
    public DeliverCardResponseBody getBody() {
        return this.body;
    }

}
