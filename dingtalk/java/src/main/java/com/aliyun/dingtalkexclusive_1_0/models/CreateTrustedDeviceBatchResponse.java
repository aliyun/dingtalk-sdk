// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustedDeviceBatchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateTrustedDeviceBatchResponseBody body;

    public static CreateTrustedDeviceBatchResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustedDeviceBatchResponse self = new CreateTrustedDeviceBatchResponse();
        return TeaModel.build(map, self);
    }

    public CreateTrustedDeviceBatchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTrustedDeviceBatchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTrustedDeviceBatchResponse setBody(CreateTrustedDeviceBatchResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTrustedDeviceBatchResponseBody getBody() {
        return this.body;
    }

}
