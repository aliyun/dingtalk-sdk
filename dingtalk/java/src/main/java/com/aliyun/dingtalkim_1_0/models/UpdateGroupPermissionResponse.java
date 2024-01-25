// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupPermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateGroupPermissionResponseBody body;

    public static UpdateGroupPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupPermissionResponse self = new UpdateGroupPermissionResponse();
        return TeaModel.build(map, self);
    }

    public UpdateGroupPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateGroupPermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateGroupPermissionResponse setBody(UpdateGroupPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateGroupPermissionResponseBody getBody() {
        return this.body;
    }

}
