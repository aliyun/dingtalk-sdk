// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomGroupRoleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCustomGroupRoleResponseBody body;

    public static CreateCustomGroupRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomGroupRoleResponse self = new CreateCustomGroupRoleResponse();
        return TeaModel.build(map, self);
    }

    public CreateCustomGroupRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCustomGroupRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCustomGroupRoleResponse setBody(CreateCustomGroupRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCustomGroupRoleResponseBody getBody() {
        return this.body;
    }

}
