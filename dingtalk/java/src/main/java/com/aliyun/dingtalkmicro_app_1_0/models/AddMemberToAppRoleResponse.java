// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddMemberToAppRoleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddMemberToAppRoleResponseBody body;

    public static AddMemberToAppRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        AddMemberToAppRoleResponse self = new AddMemberToAppRoleResponse();
        return TeaModel.build(map, self);
    }

    public AddMemberToAppRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddMemberToAppRoleResponse setBody(AddMemberToAppRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public AddMemberToAppRoleResponseBody getBody() {
        return this.body;
    }

}
