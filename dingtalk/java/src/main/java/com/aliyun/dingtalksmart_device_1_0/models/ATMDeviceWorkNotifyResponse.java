// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class ATMDeviceWorkNotifyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ATMDeviceWorkNotifyResponseBody body;

    public static ATMDeviceWorkNotifyResponse build(java.util.Map<String, ?> map) throws Exception {
        ATMDeviceWorkNotifyResponse self = new ATMDeviceWorkNotifyResponse();
        return TeaModel.build(map, self);
    }

    public ATMDeviceWorkNotifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ATMDeviceWorkNotifyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ATMDeviceWorkNotifyResponse setBody(ATMDeviceWorkNotifyResponseBody body) {
        this.body = body;
        return this;
    }
    public ATMDeviceWorkNotifyResponseBody getBody() {
        return this.body;
    }

}
