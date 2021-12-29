// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterAndActivateDeviceBatchResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RegisterAndActivateDeviceBatchResponseBody body;

    public static RegisterAndActivateDeviceBatchResponse build(java.util.Map<String, ?> map) throws Exception {
        RegisterAndActivateDeviceBatchResponse self = new RegisterAndActivateDeviceBatchResponse();
        return TeaModel.build(map, self);
    }

    public RegisterAndActivateDeviceBatchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RegisterAndActivateDeviceBatchResponse setBody(RegisterAndActivateDeviceBatchResponseBody body) {
        this.body = body;
        return this;
    }
    public RegisterAndActivateDeviceBatchResponseBody getBody() {
        return this.body;
    }

}
