// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeactivateDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeactivateDeviceResponseBody body;

    public static DeactivateDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        DeactivateDeviceResponse self = new DeactivateDeviceResponse();
        return TeaModel.build(map, self);
    }

    public DeactivateDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeactivateDeviceResponse setBody(DeactivateDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeactivateDeviceResponseBody getBody() {
        return this.body;
    }

}
