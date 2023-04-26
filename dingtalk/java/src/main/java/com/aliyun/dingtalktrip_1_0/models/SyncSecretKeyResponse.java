// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncSecretKeyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SyncSecretKeyResponseBody body;

    public static SyncSecretKeyResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncSecretKeyResponse self = new SyncSecretKeyResponse();
        return TeaModel.build(map, self);
    }

    public SyncSecretKeyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncSecretKeyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncSecretKeyResponse setBody(SyncSecretKeyResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncSecretKeyResponseBody getBody() {
        return this.body;
    }

}
