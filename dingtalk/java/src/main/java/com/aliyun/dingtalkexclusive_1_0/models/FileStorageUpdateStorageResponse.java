// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageUpdateStorageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public FileStorageUpdateStorageResponseBody body;

    public static FileStorageUpdateStorageResponse build(java.util.Map<String, ?> map) throws Exception {
        FileStorageUpdateStorageResponse self = new FileStorageUpdateStorageResponse();
        return TeaModel.build(map, self);
    }

    public FileStorageUpdateStorageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FileStorageUpdateStorageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FileStorageUpdateStorageResponse setBody(FileStorageUpdateStorageResponseBody body) {
        this.body = body;
        return this;
    }
    public FileStorageUpdateStorageResponseBody getBody() {
        return this.body;
    }

}
