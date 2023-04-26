// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreUserInfoResponseBody body;

    public static DigitalStoreUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUserInfoResponse self = new DigitalStoreUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreUserInfoResponse setBody(DigitalStoreUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreUserInfoResponseBody getBody() {
        return this.body;
    }

}
