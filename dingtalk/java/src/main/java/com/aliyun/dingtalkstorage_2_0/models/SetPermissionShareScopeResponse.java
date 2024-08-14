// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SetPermissionShareScopeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetPermissionShareScopeResponseBody body;

    public static SetPermissionShareScopeResponse build(java.util.Map<String, ?> map) throws Exception {
        SetPermissionShareScopeResponse self = new SetPermissionShareScopeResponse();
        return TeaModel.build(map, self);
    }

    public SetPermissionShareScopeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetPermissionShareScopeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetPermissionShareScopeResponse setBody(SetPermissionShareScopeResponseBody body) {
        this.body = body;
        return this;
    }
    public SetPermissionShareScopeResponseBody getBody() {
        return this.body;
    }

}
