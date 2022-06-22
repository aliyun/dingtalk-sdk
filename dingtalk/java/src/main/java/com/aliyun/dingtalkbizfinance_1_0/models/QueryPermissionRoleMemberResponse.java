// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPermissionRoleMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

    public QueryPermissionRoleMemberResponse setBody(QueryPermissionRoleMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPermissionRoleMemberResponseBody getBody() {
        return this.body;
    }

}
