// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CallbackRegiesterResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CallbackRegiesterResponseBody body;

    public static CallbackRegiesterResponse build(java.util.Map<String, ?> map) throws Exception {
        CallbackRegiesterResponse self = new CallbackRegiesterResponse();
        return TeaModel.build(map, self);
    }

    public CallbackRegiesterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CallbackRegiesterResponse setBody(CallbackRegiesterResponseBody body) {
        this.body = body;
        return this;
    }
    public CallbackRegiesterResponseBody getBody() {
        return this.body;
    }

}
