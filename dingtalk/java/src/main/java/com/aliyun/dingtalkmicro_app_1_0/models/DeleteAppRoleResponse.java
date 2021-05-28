// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class DeleteAppRoleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public DeleteAppRoleResponse setBody(DeleteAppRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteAppRoleResponseBody getBody() {
        return this.body;
    }

}
