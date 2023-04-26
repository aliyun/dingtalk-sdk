// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageCheckConnectionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public FileStorageCheckConnectionResponseBody body;

    public static FileStorageCheckConnectionResponse build(java.util.Map<String, ?> map) throws Exception {
        FileStorageCheckConnectionResponse self = new FileStorageCheckConnectionResponse();
        return TeaModel.build(map, self);
    }

    public FileStorageCheckConnectionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FileStorageCheckConnectionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FileStorageCheckConnectionResponse setBody(FileStorageCheckConnectionResponseBody body) {
        this.body = body;
        return this;
    }
    public FileStorageCheckConnectionResponseBody getBody() {
        return this.body;
    }

}
