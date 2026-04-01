// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomGroupRolesByUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCustomGroupRolesByUserResponseBody body;

    public static QueryCustomGroupRolesByUserResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomGroupRolesByUserResponse self = new QueryCustomGroupRolesByUserResponse();
        return TeaModel.build(map, self);
    }

    public QueryCustomGroupRolesByUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCustomGroupRolesByUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCustomGroupRolesByUserResponse setBody(QueryCustomGroupRolesByUserResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomGroupRolesByUserResponseBody getBody() {
        return this.body;
    }

}
