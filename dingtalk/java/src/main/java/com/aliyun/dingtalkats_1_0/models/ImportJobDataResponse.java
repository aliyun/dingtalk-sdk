// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ImportJobDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ImportJobDataResponseBody body;

    public static ImportJobDataResponse build(java.util.Map<String, ?> map) throws Exception {
        ImportJobDataResponse self = new ImportJobDataResponse();
        return TeaModel.build(map, self);
    }

    public ImportJobDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ImportJobDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ImportJobDataResponse setBody(ImportJobDataResponseBody body) {
        this.body = body;
        return this;
    }
    public ImportJobDataResponseBody getBody() {
        return this.body;
    }

}
