// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DeleteTrustedDeviceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteTrustedDeviceResponseBody body;

    public static DeleteTrustedDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteTrustedDeviceResponse self = new DeleteTrustedDeviceResponse();
        return TeaModel.build(map, self);
    }

    public DeleteTrustedDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteTrustedDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteTrustedDeviceResponse setBody(DeleteTrustedDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteTrustedDeviceResponseBody getBody() {
        return this.body;
    }

}
