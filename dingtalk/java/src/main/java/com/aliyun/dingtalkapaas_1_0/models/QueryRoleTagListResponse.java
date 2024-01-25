// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class QueryRoleTagListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryRoleTagListResponseBody body;

    public static QueryRoleTagListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRoleTagListResponse self = new QueryRoleTagListResponse();
        return TeaModel.build(map, self);
    }

    public QueryRoleTagListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRoleTagListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRoleTagListResponse setBody(QueryRoleTagListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRoleTagListResponseBody getBody() {
        return this.body;
    }

}
