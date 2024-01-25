// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmRolePermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCrmRolePermissionResponseBody body;

    public static GetCrmRolePermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCrmRolePermissionResponse self = new GetCrmRolePermissionResponse();
        return TeaModel.build(map, self);
    }

    public GetCrmRolePermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCrmRolePermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCrmRolePermissionResponse setBody(GetCrmRolePermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCrmRolePermissionResponseBody getBody() {
        return this.body;
    }

}
