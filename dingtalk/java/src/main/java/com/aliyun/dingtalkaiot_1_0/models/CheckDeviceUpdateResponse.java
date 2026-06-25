// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class CheckDeviceUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckDeviceUpdateResponseBody body;

    public static CheckDeviceUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckDeviceUpdateResponse self = new CheckDeviceUpdateResponse();
        return TeaModel.build(map, self);
    }

    public CheckDeviceUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckDeviceUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckDeviceUpdateResponse setBody(CheckDeviceUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckDeviceUpdateResponseBody getBody() {
        return this.body;
    }

}
