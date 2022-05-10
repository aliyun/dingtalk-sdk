// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageGetStorageStateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public FileStorageGetStorageStateResponse setBody(FileStorageGetStorageStateResponseBody body) {
        this.body = body;
        return this;
    }
    public FileStorageGetStorageStateResponseBody getBody() {
        return this.body;
    }

}
