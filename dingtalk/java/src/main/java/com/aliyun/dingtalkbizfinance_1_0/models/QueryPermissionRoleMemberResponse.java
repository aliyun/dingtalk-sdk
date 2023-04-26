// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPermissionRoleMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryPermissionRoleMemberResponseBody body;

    public static QueryPermissionRoleMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPermissionRoleMemberResponse self = new QueryPermissionRoleMemberResponse();
        return TeaModel.build(map, self);
    }

    public QueryPermissionRoleMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPermissionRoleMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPermissionRoleMemberResponse setBody(QueryPermissionRoleMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPermissionRoleMemberResponseBody getBody() {
        return this.body;
    }

}
