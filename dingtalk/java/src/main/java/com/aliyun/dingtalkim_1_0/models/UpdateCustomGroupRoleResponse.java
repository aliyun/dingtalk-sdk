// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomGroupRoleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCustomGroupRoleResponseBody body;

    public static UpdateCustomGroupRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomGroupRoleResponse self = new UpdateCustomGroupRoleResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCustomGroupRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCustomGroupRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCustomGroupRoleResponse setBody(UpdateCustomGroupRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCustomGroupRoleResponseBody getBody() {
        return this.body;
    }

}
