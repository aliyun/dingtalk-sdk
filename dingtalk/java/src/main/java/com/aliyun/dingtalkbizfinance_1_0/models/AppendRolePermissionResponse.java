// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class AppendRolePermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AppendRolePermissionResponseBody body;

    public static AppendRolePermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        AppendRolePermissionResponse self = new AppendRolePermissionResponse();
        return TeaModel.build(map, self);
    }

    public AppendRolePermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppendRolePermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AppendRolePermissionResponse setBody(AppendRolePermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public AppendRolePermissionResponseBody getBody() {
        return this.body;
    }

}
