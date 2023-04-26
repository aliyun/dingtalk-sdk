// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RebuildRoleScopeForAppRoleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RebuildRoleScopeForAppRoleResponseBody body;

    public static RebuildRoleScopeForAppRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        RebuildRoleScopeForAppRoleResponse self = new RebuildRoleScopeForAppRoleResponse();
        return TeaModel.build(map, self);
    }

    public RebuildRoleScopeForAppRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RebuildRoleScopeForAppRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RebuildRoleScopeForAppRoleResponse setBody(RebuildRoleScopeForAppRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public RebuildRoleScopeForAppRoleResponseBody getBody() {
        return this.body;
    }

}
