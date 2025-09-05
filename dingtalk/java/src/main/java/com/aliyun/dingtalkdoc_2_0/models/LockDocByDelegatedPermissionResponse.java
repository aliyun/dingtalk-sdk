// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class LockDocByDelegatedPermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public LockDocByDelegatedPermissionResponseBody body;

    public static LockDocByDelegatedPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        LockDocByDelegatedPermissionResponse self = new LockDocByDelegatedPermissionResponse();
        return TeaModel.build(map, self);
    }

    public LockDocByDelegatedPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LockDocByDelegatedPermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LockDocByDelegatedPermissionResponse setBody(LockDocByDelegatedPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public LockDocByDelegatedPermissionResponseBody getBody() {
        return this.body;
    }

}
