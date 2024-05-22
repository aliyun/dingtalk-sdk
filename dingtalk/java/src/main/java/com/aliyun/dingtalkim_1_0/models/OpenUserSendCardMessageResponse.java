// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenUserSendCardMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenUserSendCardMessageResponseBody body;

    public static OpenUserSendCardMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenUserSendCardMessageResponse self = new OpenUserSendCardMessageResponse();
        return TeaModel.build(map, self);
    }

    public OpenUserSendCardMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenUserSendCardMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenUserSendCardMessageResponse setBody(OpenUserSendCardMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenUserSendCardMessageResponseBody getBody() {
        return this.body;
    }

}
