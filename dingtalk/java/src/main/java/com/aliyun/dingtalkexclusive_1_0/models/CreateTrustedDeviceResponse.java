// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustedDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateTrustedDeviceResponseBody body;

    public static CreateTrustedDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustedDeviceResponse self = new CreateTrustedDeviceResponse();
        return TeaModel.build(map, self);
    }

    public CreateTrustedDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTrustedDeviceResponse setBody(CreateTrustedDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTrustedDeviceResponseBody getBody() {
        return this.body;
    }

}
