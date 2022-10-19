// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RegisterOpenInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RegisterOpenInfoResponseBody body;

    public static RegisterOpenInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        RegisterOpenInfoResponse self = new RegisterOpenInfoResponse();
        return TeaModel.build(map, self);
    }

    public RegisterOpenInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RegisterOpenInfoResponse setBody(RegisterOpenInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public RegisterOpenInfoResponseBody getBody() {
        return this.body;
    }

}
