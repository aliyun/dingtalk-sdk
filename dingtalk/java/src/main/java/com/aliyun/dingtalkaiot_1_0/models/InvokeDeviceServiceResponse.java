// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class InvokeDeviceServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InvokeDeviceServiceResponseBody body;

    public static InvokeDeviceServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        InvokeDeviceServiceResponse self = new InvokeDeviceServiceResponse();
        return TeaModel.build(map, self);
    }

    public InvokeDeviceServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvokeDeviceServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InvokeDeviceServiceResponse setBody(InvokeDeviceServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public InvokeDeviceServiceResponseBody getBody() {
        return this.body;
    }

}
