// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitVPaasDeviceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InitVPaasDeviceResponseBody body;

    public static InitVPaasDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        InitVPaasDeviceResponse self = new InitVPaasDeviceResponse();
        return TeaModel.build(map, self);
    }

    public InitVPaasDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InitVPaasDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InitVPaasDeviceResponse setBody(InitVPaasDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public InitVPaasDeviceResponseBody getBody() {
        return this.body;
    }

}
