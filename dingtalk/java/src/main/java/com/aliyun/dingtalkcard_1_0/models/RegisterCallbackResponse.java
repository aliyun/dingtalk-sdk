// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class RegisterCallbackResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RegisterCallbackResponseBody body;

    public static RegisterCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        RegisterCallbackResponse self = new RegisterCallbackResponse();
        return TeaModel.build(map, self);
    }

    public RegisterCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RegisterCallbackResponse setBody(RegisterCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public RegisterCallbackResponseBody getBody() {
        return this.body;
    }

}
