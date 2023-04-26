// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterAndActivateDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RegisterAndActivateDeviceResponseBody body;

    public static RegisterAndActivateDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        RegisterAndActivateDeviceResponse self = new RegisterAndActivateDeviceResponse();
        return TeaModel.build(map, self);
    }

    public RegisterAndActivateDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RegisterAndActivateDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RegisterAndActivateDeviceResponse setBody(RegisterAndActivateDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public RegisterAndActivateDeviceResponseBody getBody() {
        return this.body;
    }

}
