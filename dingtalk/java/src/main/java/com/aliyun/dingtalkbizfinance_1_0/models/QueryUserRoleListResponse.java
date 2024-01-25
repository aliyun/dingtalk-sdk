// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserRoleListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserRoleListResponseBody body;

    public static QueryUserRoleListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserRoleListResponse self = new QueryUserRoleListResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserRoleListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserRoleListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserRoleListResponse setBody(QueryUserRoleListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserRoleListResponseBody getBody() {
        return this.body;
    }

}
