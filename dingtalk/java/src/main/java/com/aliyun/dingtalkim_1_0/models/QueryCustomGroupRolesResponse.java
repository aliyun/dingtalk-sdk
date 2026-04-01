// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomGroupRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCustomGroupRolesResponseBody body;

    public static QueryCustomGroupRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomGroupRolesResponse self = new QueryCustomGroupRolesResponse();
        return TeaModel.build(map, self);
    }

    public QueryCustomGroupRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCustomGroupRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCustomGroupRolesResponse setBody(QueryCustomGroupRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCustomGroupRolesResponseBody getBody() {
        return this.body;
    }

}
