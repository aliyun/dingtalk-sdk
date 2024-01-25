// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ValidateUserRoleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ValidateUserRoleResponseBody body;

    public static ValidateUserRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        ValidateUserRoleResponse self = new ValidateUserRoleResponse();
        return TeaModel.build(map, self);
    }

    public ValidateUserRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ValidateUserRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ValidateUserRoleResponse setBody(ValidateUserRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateUserRoleResponseBody getBody() {
        return this.body;
    }

}
