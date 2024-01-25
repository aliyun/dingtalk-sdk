// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CheckWritePermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckWritePermissionResponseBody body;

    public static CheckWritePermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckWritePermissionResponse self = new CheckWritePermissionResponse();
        return TeaModel.build(map, self);
    }

    public CheckWritePermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckWritePermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckWritePermissionResponse setBody(CheckWritePermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckWritePermissionResponseBody getBody() {
        return this.body;
    }

}
