// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageGetStorageStateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FileStorageGetStorageStateResponseBody body;

    public static FileStorageGetStorageStateResponse build(java.util.Map<String, ?> map) throws Exception {
        FileStorageGetStorageStateResponse self = new FileStorageGetStorageStateResponse();
        return TeaModel.build(map, self);
    }

    public FileStorageGetStorageStateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FileStorageGetStorageStateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FileStorageGetStorageStateResponse setBody(FileStorageGetStorageStateResponseBody body) {
        this.body = body;
        return this;
    }
    public FileStorageGetStorageStateResponseBody getBody() {
        return this.body;
    }

}
