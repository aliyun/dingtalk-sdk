// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class GetPermissionShareScopeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPermissionShareScopeResponseBody body;

    public static GetPermissionShareScopeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPermissionShareScopeResponse self = new GetPermissionShareScopeResponse();
        return TeaModel.build(map, self);
    }

    public GetPermissionShareScopeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPermissionShareScopeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPermissionShareScopeResponse setBody(GetPermissionShareScopeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPermissionShareScopeResponseBody getBody() {
        return this.body;
    }

}
