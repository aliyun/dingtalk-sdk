// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryUserRoleListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryUserRoleListResponse setBody(QueryUserRoleListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserRoleListResponseBody getBody() {
        return this.body;
    }

}
