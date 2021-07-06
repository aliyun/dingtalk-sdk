// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserRolesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryUserRolesResponseBody body;

    public static QueryUserRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserRolesResponse self = new QueryUserRolesResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserRolesResponse setBody(QueryUserRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserRolesResponseBody getBody() {
        return this.body;
    }

}
