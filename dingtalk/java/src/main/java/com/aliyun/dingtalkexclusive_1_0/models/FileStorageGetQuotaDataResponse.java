// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageGetQuotaDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FileStorageGetQuotaDataResponseBody body;

    public static FileStorageGetQuotaDataResponse build(java.util.Map<String, ?> map) throws Exception {
        FileStorageGetQuotaDataResponse self = new FileStorageGetQuotaDataResponse();
        return TeaModel.build(map, self);
    }

    public FileStorageGetQuotaDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FileStorageGetQuotaDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FileStorageGetQuotaDataResponse setBody(FileStorageGetQuotaDataResponseBody body) {
        this.body = body;
        return this;
    }
    public FileStorageGetQuotaDataResponseBody getBody() {
        return this.body;
    }

}
