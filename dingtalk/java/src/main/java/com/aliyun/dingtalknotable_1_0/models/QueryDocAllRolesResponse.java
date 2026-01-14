// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class QueryDocAllRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDocAllRolesResponseBody body;

    public static QueryDocAllRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDocAllRolesResponse self = new QueryDocAllRolesResponse();
        return TeaModel.build(map, self);
    }

    public QueryDocAllRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDocAllRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDocAllRolesResponse setBody(QueryDocAllRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDocAllRolesResponseBody getBody() {
        return this.body;
    }

}
