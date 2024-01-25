// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SetPermissionInheritanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetPermissionInheritanceResponseBody body;

    public static SetPermissionInheritanceResponse build(java.util.Map<String, ?> map) throws Exception {
        SetPermissionInheritanceResponse self = new SetPermissionInheritanceResponse();
        return TeaModel.build(map, self);
    }

    public SetPermissionInheritanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetPermissionInheritanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetPermissionInheritanceResponse setBody(SetPermissionInheritanceResponseBody body) {
        this.body = body;
        return this;
    }
    public SetPermissionInheritanceResponseBody getBody() {
        return this.body;
    }

}
