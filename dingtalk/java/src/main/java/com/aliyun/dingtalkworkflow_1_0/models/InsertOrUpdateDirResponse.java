// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class InsertOrUpdateDirResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InsertOrUpdateDirResponseBody body;

    public static InsertOrUpdateDirResponse build(java.util.Map<String, ?> map) throws Exception {
        InsertOrUpdateDirResponse self = new InsertOrUpdateDirResponse();
        return TeaModel.build(map, self);
    }

    public InsertOrUpdateDirResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InsertOrUpdateDirResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InsertOrUpdateDirResponse setBody(InsertOrUpdateDirResponseBody body) {
        this.body = body;
        return this;
    }
    public InsertOrUpdateDirResponseBody getBody() {
        return this.body;
    }

}
