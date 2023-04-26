// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public InitDeviceResponseBody body;

    public static InitDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        InitDeviceResponse self = new InitDeviceResponse();
        return TeaModel.build(map, self);
    }

    public InitDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InitDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InitDeviceResponse setBody(InitDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public InitDeviceResponseBody getBody() {
        return this.body;
    }

}
