// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class SignInResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SignInResponseBody body;

    public static SignInResponse build(java.util.Map<String, ?> map) throws Exception {
        SignInResponse self = new SignInResponse();
        return TeaModel.build(map, self);
    }

    public SignInResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SignInResponse setBody(SignInResponseBody body) {
        this.body = body;
        return this;
    }
    public SignInResponseBody getBody() {
        return this.body;
    }

}
