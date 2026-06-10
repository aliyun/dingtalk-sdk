// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class PrepareImportUploadResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PrepareImportUploadResponseBody body;

    public static PrepareImportUploadResponse build(java.util.Map<String, ?> map) throws Exception {
        PrepareImportUploadResponse self = new PrepareImportUploadResponse();
        return TeaModel.build(map, self);
    }

    public PrepareImportUploadResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PrepareImportUploadResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PrepareImportUploadResponse setBody(PrepareImportUploadResponseBody body) {
        this.body = body;
        return this;
    }
    public PrepareImportUploadResponseBody getBody() {
        return this.body;
    }

}
