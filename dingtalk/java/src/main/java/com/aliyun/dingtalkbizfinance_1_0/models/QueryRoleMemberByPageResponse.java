// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryRoleMemberByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryRoleMemberByPageResponseBody body;

    public static QueryRoleMemberByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRoleMemberByPageResponse self = new QueryRoleMemberByPageResponse();
        return TeaModel.build(map, self);
    }

    public QueryRoleMemberByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRoleMemberByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRoleMemberByPageResponse setBody(QueryRoleMemberByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRoleMemberByPageResponseBody getBody() {
        return this.body;
    }

}
