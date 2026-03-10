// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUserGroupRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserGroupRolesResponseBody body;

    public static QueryUserGroupRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserGroupRolesResponse self = new QueryUserGroupRolesResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserGroupRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserGroupRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserGroupRolesResponse setBody(QueryUserGroupRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserGroupRolesResponseBody getBody() {
        return this.body;
    }

}
