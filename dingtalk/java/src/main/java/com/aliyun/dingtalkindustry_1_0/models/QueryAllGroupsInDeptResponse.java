// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllGroupsInDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public QueryAllGroupsInDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllGroupsInDeptResponse setBody(QueryAllGroupsInDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllGroupsInDeptResponseBody getBody() {
        return this.body;
    }

}
