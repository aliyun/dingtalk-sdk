// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ExecuteImportResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExecuteImportResponseBody body;

    public static ExecuteImportResponse build(java.util.Map<String, ?> map) throws Exception {
        ExecuteImportResponse self = new ExecuteImportResponse();
        return TeaModel.build(map, self);
    }

    public ExecuteImportResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExecuteImportResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExecuteImportResponse setBody(ExecuteImportResponseBody body) {
        this.body = body;
        return this;
    }
    public ExecuteImportResponseBody getBody() {
        return this.body;
    }

}
