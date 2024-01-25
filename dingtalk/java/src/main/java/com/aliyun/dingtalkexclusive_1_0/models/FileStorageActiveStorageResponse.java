// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageActiveStorageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FileStorageActiveStorageResponseBody body;

    public static FileStorageActiveStorageResponse build(java.util.Map<String, ?> map) throws Exception {
        FileStorageActiveStorageResponse self = new FileStorageActiveStorageResponse();
        return TeaModel.build(map, self);
    }

    public FileStorageActiveStorageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FileStorageActiveStorageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FileStorageActiveStorageResponse setBody(FileStorageActiveStorageResponseBody body) {
        this.body = body;
        return this;
    }
    public FileStorageActiveStorageResponseBody getBody() {
        return this.body;
    }

}
