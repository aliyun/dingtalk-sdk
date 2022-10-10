// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ActivateDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ActivateDeviceResponseBody body;

    public static ActivateDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        ActivateDeviceResponse self = new ActivateDeviceResponse();
        return TeaModel.build(map, self);
    }

    public ActivateDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ActivateDeviceResponse setBody(ActivateDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public ActivateDeviceResponseBody getBody() {
        return this.body;
    }

}
