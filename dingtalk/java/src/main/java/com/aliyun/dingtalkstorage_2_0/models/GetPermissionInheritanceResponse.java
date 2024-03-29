// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class GetPermissionInheritanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPermissionInheritanceResponseBody body;

    public static GetPermissionInheritanceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPermissionInheritanceResponse self = new GetPermissionInheritanceResponse();
        return TeaModel.build(map, self);
    }

    public GetPermissionInheritanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPermissionInheritanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPermissionInheritanceResponse setBody(GetPermissionInheritanceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPermissionInheritanceResponseBody getBody() {
        return this.body;
    }

}
