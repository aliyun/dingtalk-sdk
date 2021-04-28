// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrajectory_1_0.models;

import com.aliyun.tea.*;

public class QueryAppActiveUsersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryAppActiveUsersResponseBody body;

    public static QueryAppActiveUsersResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAppActiveUsersResponse self = new QueryAppActiveUsersResponse();
        return TeaModel.build(map, self);
    }

    public QueryAppActiveUsersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAppActiveUsersResponse setBody(QueryAppActiveUsersResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAppActiveUsersResponseBody getBody() {
        return this.body;
    }

}
