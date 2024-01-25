// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllMemberByDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAllMemberByDeptResponseBody body;

    public static QueryAllMemberByDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllMemberByDeptResponse self = new QueryAllMemberByDeptResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllMemberByDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllMemberByDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllMemberByDeptResponse setBody(QueryAllMemberByDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllMemberByDeptResponseBody getBody() {
        return this.body;
    }

}
