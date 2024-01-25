// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class DeleteAppRoleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteAppRoleResponseBody body;

    public static DeleteAppRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteAppRoleResponse self = new DeleteAppRoleResponse();
        return TeaModel.build(map, self);
    }

    public DeleteAppRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteAppRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteAppRoleResponse setBody(DeleteAppRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteAppRoleResponseBody getBody() {
        return this.body;
    }

}
