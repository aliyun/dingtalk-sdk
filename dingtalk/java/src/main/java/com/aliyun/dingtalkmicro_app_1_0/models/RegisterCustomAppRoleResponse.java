// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RegisterCustomAppRoleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RegisterCustomAppRoleResponseBody body;

    public static RegisterCustomAppRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        RegisterCustomAppRoleResponse self = new RegisterCustomAppRoleResponse();
        return TeaModel.build(map, self);
    }

    public RegisterCustomAppRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RegisterCustomAppRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RegisterCustomAppRoleResponse setBody(RegisterCustomAppRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public RegisterCustomAppRoleResponseBody getBody() {
        return this.body;
    }

}
