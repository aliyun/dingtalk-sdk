// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetAppRoleScopeByRoleIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetAppRoleScopeByRoleIdResponseBody body;

    public static GetAppRoleScopeByRoleIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAppRoleScopeByRoleIdResponse self = new GetAppRoleScopeByRoleIdResponse();
        return TeaModel.build(map, self);
    }

    public GetAppRoleScopeByRoleIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAppRoleScopeByRoleIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAppRoleScopeByRoleIdResponse setBody(GetAppRoleScopeByRoleIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAppRoleScopeByRoleIdResponseBody getBody() {
        return this.body;
    }

}
