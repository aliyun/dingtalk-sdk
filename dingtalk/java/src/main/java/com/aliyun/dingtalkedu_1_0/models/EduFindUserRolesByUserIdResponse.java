// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduFindUserRolesByUserIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EduFindUserRolesByUserIdResponseBody body;

    public static EduFindUserRolesByUserIdResponse build(java.util.Map<String, ?> map) throws Exception {
        EduFindUserRolesByUserIdResponse self = new EduFindUserRolesByUserIdResponse();
        return TeaModel.build(map, self);
    }

    public EduFindUserRolesByUserIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EduFindUserRolesByUserIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EduFindUserRolesByUserIdResponse setBody(EduFindUserRolesByUserIdResponseBody body) {
        this.body = body;
        return this;
    }
    public EduFindUserRolesByUserIdResponseBody getBody() {
        return this.body;
    }

}
