// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class UpdatePermissionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdatePermissionResponseBody body;

    public static UpdatePermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdatePermissionResponse self = new UpdatePermissionResponse();
        return TeaModel.build(map, self);
    }

    public UpdatePermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdatePermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdatePermissionResponse setBody(UpdatePermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePermissionResponseBody getBody() {
        return this.body;
    }

}
