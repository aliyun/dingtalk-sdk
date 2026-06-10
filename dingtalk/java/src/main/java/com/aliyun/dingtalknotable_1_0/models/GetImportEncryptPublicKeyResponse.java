// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetImportEncryptPublicKeyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetImportEncryptPublicKeyResponseBody body;

    public static GetImportEncryptPublicKeyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetImportEncryptPublicKeyResponse self = new GetImportEncryptPublicKeyResponse();
        return TeaModel.build(map, self);
    }

    public GetImportEncryptPublicKeyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetImportEncryptPublicKeyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetImportEncryptPublicKeyResponse setBody(GetImportEncryptPublicKeyResponseBody body) {
        this.body = body;
        return this;
    }
    public GetImportEncryptPublicKeyResponseBody getBody() {
        return this.body;
    }

}
