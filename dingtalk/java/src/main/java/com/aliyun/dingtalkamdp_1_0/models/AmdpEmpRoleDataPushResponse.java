// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpEmpRoleDataPushResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AmdpEmpRoleDataPushResponseBody body;

    public static AmdpEmpRoleDataPushResponse build(java.util.Map<String, ?> map) throws Exception {
        AmdpEmpRoleDataPushResponse self = new AmdpEmpRoleDataPushResponse();
        return TeaModel.build(map, self);
    }

    public AmdpEmpRoleDataPushResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AmdpEmpRoleDataPushResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AmdpEmpRoleDataPushResponse setBody(AmdpEmpRoleDataPushResponseBody body) {
        this.body = body;
        return this;
    }
    public AmdpEmpRoleDataPushResponseBody getBody() {
        return this.body;
    }

}
