// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomUserRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCustomUserRolesResponseBody body;

    public static CreateCustomUserRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomUserRolesResponse self = new CreateCustomUserRolesResponse();
        return TeaModel.build(map, self);
    }

    public CreateCustomUserRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCustomUserRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCustomUserRolesResponse setBody(CreateCustomUserRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCustomUserRolesResponseBody getBody() {
        return this.body;
    }

}
