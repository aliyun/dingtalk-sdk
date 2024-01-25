// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class RegisterAndActivateDeviceBatchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public RegisterAndActivateDeviceBatchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RegisterAndActivateDeviceBatchResponse setBody(RegisterAndActivateDeviceBatchResponseBody body) {
        this.body = body;
        return this;
    }
    public RegisterAndActivateDeviceBatchResponseBody getBody() {
        return this.body;
    }

}
