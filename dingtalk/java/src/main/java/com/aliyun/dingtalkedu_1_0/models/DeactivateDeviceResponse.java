// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeactivateDeviceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public DeactivateDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeactivateDeviceResponse setBody(DeactivateDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeactivateDeviceResponseBody getBody() {
        return this.body;
    }

}
