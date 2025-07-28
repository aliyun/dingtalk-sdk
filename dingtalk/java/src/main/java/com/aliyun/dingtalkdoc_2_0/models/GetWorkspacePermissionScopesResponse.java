// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetWorkspacePermissionScopesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetWorkspacePermissionScopesResponseBody body;

    public static GetWorkspacePermissionScopesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspacePermissionScopesResponse self = new GetWorkspacePermissionScopesResponse();
        return TeaModel.build(map, self);
    }

    public GetWorkspacePermissionScopesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetWorkspacePermissionScopesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetWorkspacePermissionScopesResponse setBody(GetWorkspacePermissionScopesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWorkspacePermissionScopesResponseBody getBody() {
        return this.body;
    }

}
