// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupsInDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryAllGroupsInDeptResponseBody body;

    public static QueryAllGroupsInDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllGroupsInDeptResponse self = new QueryAllGroupsInDeptResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllGroupsInDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllGroupsInDeptResponse setBody(QueryAllGroupsInDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllGroupsInDeptResponseBody getBody() {
        return this.body;
    }

}
