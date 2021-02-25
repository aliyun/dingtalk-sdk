// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class AuthUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AuthUrlResponseBody body;

    public static AuthUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        AuthUrlResponse self = new AuthUrlResponse();
        return TeaModel.build(map, self);
    }

    public AuthUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AuthUrlResponse setBody(AuthUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public AuthUrlResponseBody getBody() {
        return this.body;
    }

}
