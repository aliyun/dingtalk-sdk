// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitVPaasDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public InitVPaasDeviceResponse setBody(InitVPaasDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public InitVPaasDeviceResponseBody getBody() {
        return this.body;
    }

}
