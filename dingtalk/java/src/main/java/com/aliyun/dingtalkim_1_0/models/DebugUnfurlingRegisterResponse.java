// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DebugUnfurlingRegisterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DebugUnfurlingRegisterResponseBody body;

    public static DebugUnfurlingRegisterResponse build(java.util.Map<String, ?> map) throws Exception {
        DebugUnfurlingRegisterResponse self = new DebugUnfurlingRegisterResponse();
        return TeaModel.build(map, self);
    }

    public DebugUnfurlingRegisterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DebugUnfurlingRegisterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DebugUnfurlingRegisterResponse setBody(DebugUnfurlingRegisterResponseBody body) {
        this.body = body;
        return this;
    }
    public DebugUnfurlingRegisterResponseBody getBody() {
        return this.body;
    }

}
