// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class QueryRoleTagListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryRoleTagListResponse setBody(QueryRoleTagListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRoleTagListResponseBody getBody() {
        return this.body;
    }

}
