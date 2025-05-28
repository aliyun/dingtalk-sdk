// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateTrustedDeviceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateTrustedDeviceResponseBody body;

    public static UpdateTrustedDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTrustedDeviceResponse self = new UpdateTrustedDeviceResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTrustedDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTrustedDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateTrustedDeviceResponse setBody(UpdateTrustedDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTrustedDeviceResponseBody getBody() {
        return this.body;
    }

}
