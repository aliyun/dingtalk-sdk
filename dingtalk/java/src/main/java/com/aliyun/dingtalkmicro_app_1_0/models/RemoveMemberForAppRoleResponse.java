// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RemoveMemberForAppRoleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveMemberForAppRoleResponseBody body;

    public static RemoveMemberForAppRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveMemberForAppRoleResponse self = new RemoveMemberForAppRoleResponse();
        return TeaModel.build(map, self);
    }

    public RemoveMemberForAppRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveMemberForAppRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveMemberForAppRoleResponse setBody(RemoveMemberForAppRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveMemberForAppRoleResponseBody getBody() {
        return this.body;
    }

}
