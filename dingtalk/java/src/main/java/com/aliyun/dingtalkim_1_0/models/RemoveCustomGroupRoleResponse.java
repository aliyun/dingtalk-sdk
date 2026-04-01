// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveCustomGroupRoleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RemoveCustomGroupRoleResponseBody body;

    public static RemoveCustomGroupRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveCustomGroupRoleResponse self = new RemoveCustomGroupRoleResponse();
        return TeaModel.build(map, self);
    }

    public RemoveCustomGroupRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveCustomGroupRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveCustomGroupRoleResponse setBody(RemoveCustomGroupRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveCustomGroupRoleResponseBody getBody() {
        return this.body;
    }

}
