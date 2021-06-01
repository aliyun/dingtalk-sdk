// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CheckWritePermissionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CheckWritePermissionResponse setBody(CheckWritePermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckWritePermissionResponseBody getBody() {
        return this.body;
    }

}
