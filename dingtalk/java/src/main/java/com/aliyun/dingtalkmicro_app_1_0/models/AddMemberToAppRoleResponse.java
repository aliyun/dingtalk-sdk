// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddMemberToAppRoleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public AddMemberToAppRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddMemberToAppRoleResponse setBody(AddMemberToAppRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public AddMemberToAppRoleResponseBody getBody() {
        return this.body;
    }

}
