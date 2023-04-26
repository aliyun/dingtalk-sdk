// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMembersOfGroupRoleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryMembersOfGroupRoleResponseBody body;

    public static QueryMembersOfGroupRoleResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMembersOfGroupRoleResponse self = new QueryMembersOfGroupRoleResponse();
        return TeaModel.build(map, self);
    }

    public QueryMembersOfGroupRoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMembersOfGroupRoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMembersOfGroupRoleResponse setBody(QueryMembersOfGroupRoleResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMembersOfGroupRoleResponseBody getBody() {
        return this.body;
    }

}
